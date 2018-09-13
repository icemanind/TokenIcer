using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TokenIcer
{
    public class Processor
    {
        private readonly Dictionary<string, string> _tokens;
        private string _inputString;
        private int _index;

        public bool IgnoreSpaces { private get; set; }

        public string InputString
        {
            set => _inputString = value;
        }

        public Processor()
        {
            _tokens = new Dictionary<string, string>();
            _index = 0;
            _inputString = string.Empty;
            IgnoreSpaces = false;
        }

        public void ResetProcessor()
        {
            _tokens.Clear();
            _inputString = string.Empty;
            _index = 0;
        }

        public string AddRegExToken(string regEx, string identifier)
        {
            if (_tokens.ContainsKey(identifier.Trim()))
                return "";

            identifier = identifier.Trim();
            if (CheckValidity(regEx) == false)
            {
                return GetInvalidMessage(regEx);
            }
            _tokens.Add(identifier, regEx);

            return "";
        }

        private string GetInvalidMessage(string regEx)
        {
            try
            {
                var r = new Regex(regEx);

                // ReSharper disable ReturnValueOfPureMethodIsNotUsed
                r.Match("");
                // ReSharper restore ReturnValueOfPureMethodIsNotUsed
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "";
        }

        private bool CheckValidity(string regEx)
        {
            try
            {
                var r = new Regex(regEx);

                // ReSharper disable ReturnValueOfPureMethodIsNotUsed
                r.Match("");
                // ReSharper restore ReturnValueOfPureMethodIsNotUsed
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public Token GetToken()
        {
            if (_index >= _inputString.Length) return null;

            while ((_inputString[_index] == ' ' || _inputString[_index] == '\t') && IgnoreSpaces)
            {
                _index++;
                if (_index >= _inputString.Length) return null;
            }

            foreach (KeyValuePair<string, string> pair in _tokens)
            {
                var r = new Regex(pair.Value);
                var m = r.Match(_inputString, _index);

                if (!m.Success || m.Index != _index) continue;

                if (m.Length == 0)
                    continue;
                _index += m.Length;
                return new Token(pair.Key, m.Value);
            }
            _index++;
            return new Token("Undefined", (_inputString[_index - 1]).ToString(CultureInfo.InvariantCulture));
        }
    }
}
