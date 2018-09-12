namespace TokenIcer
{
    public class Token
    {
        public string TokenName { get; set; }

        public string TokenValue { get; set; }

        public Token(string name, string value)
        {
            TokenName = name;
            TokenValue = value;
        }
    }
}
