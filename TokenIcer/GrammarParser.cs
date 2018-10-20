using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TokenIcer
{
    public class GrammarParser
    {
        protected readonly Dictionary<Tokens, string> _tokens;
        protected readonly Dictionary<Tokens, MatchCollection> _regExMatchCollection;
        private string _inputString;
        private int _index;

        /// <summary>
        /// Tokens is an enumeration of all possible token values.
        /// </summary>
        public enum Tokens
        {
            Undefined = 0,
            TokenIndentifier = 1,
            Identifier = 2,
            LeftParen = 3,
            RightParen = 4,
            Or = 5,
            Optional = 6,
            Newline = 7
        }

        /// <summary>
        /// InputString Property
        /// </summary>
        /// <value>
        /// The string value that holds the input string.
        /// </value>
        public virtual string InputString
        {
            set
            {
                _inputString = value;
                PrepareRegex();
            }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <remarks>
        /// The constructor initalizes memory and adds all of the tokens to the token dictionary.
        /// </remarks>
        public GrammarParser()
        {
            _tokens = new Dictionary<Tokens, string>();
            _regExMatchCollection = new Dictionary<Tokens, MatchCollection>();
            _index = 0;
            _inputString = string.Empty;

            _tokens.Add(Tokens.TokenIndentifier, "\\`[A-Za-z0-9_]+\\`");
            _tokens.Add(Tokens.Identifier, "[A-Za-z0-9_]+\\:");
            _tokens.Add(Tokens.LeftParen, "\\(");
            _tokens.Add(Tokens.RightParen, "\\)");
            _tokens.Add(Tokens.Or, "\\|");
            _tokens.Add(Tokens.Optional, "\\?");
            _tokens.Add(Tokens.Newline, "[\\n\\r]+");
        }

        /// <summary>
        /// PrepareRegex prepares the regex for parsing by pre-matching the Regex tokens.
        /// </summary>
        protected virtual void PrepareRegex()
        {
            _regExMatchCollection.Clear();
            foreach (KeyValuePair<Tokens, string> pair in _tokens)
            {
                _regExMatchCollection.Add(pair.Key, Regex.Matches(_inputString, pair.Value));
            }
        }

        /// <summary>
        /// ResetParser resets the parser to its inital state. Reloading InputString is required.
        /// </summary>
        /// <seealso cref="InputString">
        public virtual void ResetParser()
        {
            _index = 0;
            _inputString = string.Empty;
            _regExMatchCollection.Clear();
        }

        /// <summary>
        /// GetToken gets the next token in queue
        /// </summary>
        /// <remarks>
        /// GetToken attempts to the match the next character(s) using the
        /// Regex rules defined in the dictionary. If a match can not be
        /// located, then an Undefined token will be created with an empty
        /// string value. In addition, the token pointer will be incremented
        /// by one so that this token doesn't attempt to get identified again by
        /// GetToken()
        /// </remarks>
        public virtual Token GetToken()
        {
            if (_index >= _inputString.Length)
                return null;

            while (_inputString[_index] == ' ' || _inputString[_index] == '\t')
            {
                _index++;
                if (_index >= _inputString.Length) return null;
            }

            foreach (KeyValuePair<Tokens, MatchCollection> pair in _regExMatchCollection)
            {
                foreach (Match match in pair.Value)
                {
                    if (match.Index == _index)
                    {
                        _index += match.Length;
                        return new Token(pair.Key, match.Value);
                    }

                    if (match.Index > _index)
                    {
                        break;
                    }
                }
            }
            _index++;
            return new Token(Tokens.Undefined, (_inputString[_index - 1]).ToString());
        }

        /// <summary>
        /// Returns the next token that GetToken() will return.
        /// </summary>
        /// <seealso cref="Peek(PeekToken)">
        public virtual PeekToken Peek()
        {
            return Peek(new PeekToken(_index, new Token(Tokens.Undefined, string.Empty)));
        }

        /// <summary>
        /// Returns the next token after the Token passed here
        /// </summary>
        /// <param name="peekToken">The PeekToken token returned from a previous Peek() call</param>
        /// <seealso cref="Peek()">
        public virtual PeekToken Peek(PeekToken peekToken)
        {
            int oldIndex = _index;

            _index = peekToken.TokenIndex;

            if (_index >= _inputString.Length)
            {
                _index = oldIndex;
                return null;
            }


            while (_inputString[_index] == ' ' || _inputString[_index] == '\t')
            {
                _index++;
                if (_index >= _inputString.Length) return null;
            }


            foreach (KeyValuePair<Tokens, string> pair in _tokens)
            {
                Regex r = new Regex(pair.Value);
                Match m = r.Match(_inputString, _index);

                if (m.Success && m.Index == _index)
                {
                    _index += m.Length;
                    PeekToken pt = new PeekToken(_index, new Token(pair.Key, m.Value));
                    _index = oldIndex;
                    return pt;
                }
            }
            PeekToken pt2 = new PeekToken(_index + 1, new Token(Tokens.Undefined, (_inputString[_index]).ToString()));
            _index = oldIndex;
            return pt2;
        }

        /// <summary>
        /// a Token object class
        /// </summary>
        /// <remarks>
        /// A Token object holds the token and token value.
        /// </remarks>
        public class Token
        {
            public GrammarParser.Tokens TokenName { get; set; }

            public string TokenValue { get; set; }

            public Token(GrammarParser.Tokens name, string value)
            {
                TokenName = name;
                TokenValue = value;
            }
        }

        /// <summary>
        /// A PeekToken object class
        /// </summary>
        /// <remarks>
        /// A PeekToken is a special pointer object that can be used to Peek() several
        /// tokens ahead in the GetToken() queue.
        /// </remarks>
        public class PeekToken
        {
            public int TokenIndex { get; set; }

            public Token TokenPeek { get; set; }

            public PeekToken(int index, Token value)
            {
                TokenIndex = index;
                TokenPeek = value;
            }
        }
    }
}
