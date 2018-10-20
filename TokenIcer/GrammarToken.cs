namespace TokenIcer
{
    public class GrammarToken
    {
        public string TokenName { get; set; }

        public Token TokenValue { get; set; }

        public GrammarToken(string name, Token value)
        {
            TokenName = name;
            TokenValue = value;
        }
    }
}
