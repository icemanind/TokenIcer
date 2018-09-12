using System.IO;
using System.Reflection;

namespace TokenIcer.Languages
{
    public class LanguageCSharp : ITokenIcerLanguage
    {
        public string AddToken(string identifier, string regEx)
        {
            regEx = regEx.Replace("\\", "\\\\").Replace("\"", "\\\"");
            if (IsCSKeyword(identifier))
                identifier = "@" + identifier;
            return "_tokens.Add(Tokens." + identifier + ", \"" + regEx + "\");";
        }

        public string GetCommentIdentifier()
        {
            return "//";
        }

        public string GetXmlCommentIdentifier()
        {
            return "///";
        }

        public string CreateEnum(string identifier, int num, bool lastEnum)
        {
            if (IsCSKeyword(identifier))
                identifier = "@" + identifier;
            if (lastEnum == false)
                return identifier + "=" + num.ToString() + ",";
            return identifier + "=" + num.ToString();
        }

        public string GetSkeletonCode()
        {
            StreamReader textStreamReader;
            Assembly assembly = Assembly.GetExecutingAssembly();

            try
            {
                textStreamReader =
                    new StreamReader(assembly.GetManifestResourceStream("TokenIcer.LanguageFiles.CSharp.txt"));
            }
            catch
            {
                return "";
            }

            string retval = textStreamReader.ReadToEnd();
            textStreamReader.Close();
            return retval;
        }

        public int GetIndentWidth(int partNum)
        {
            if (partNum == 1)
                return 3;
            return 3;
        }

        private bool IsCSKeyword(string keyword)
        {
            if (keyword == "abstract" || keyword == "new" || keyword == "event" ||
              keyword == "struct" || keyword == "as" || keyword == "explicit" ||
              keyword == "null" || keyword == "switch" || keyword == "base" ||
              keyword == "extern" || keyword == "object" || keyword == "this" ||
              keyword == "bool" || keyword == "false" || keyword == "operator" ||
              keyword == "throw" || keyword == "break" || keyword == "finally" ||
              keyword == "out" || keyword == "true" || keyword == "byte" ||
              keyword == "fixed" || keyword == "override" || keyword == "try" ||
              keyword == "case" || keyword == "float" || keyword == "params" ||
              keyword == "typeof" || keyword == "catch" || keyword == "for" ||
              keyword == "private" || keyword == "uint" || keyword == "char" ||
              keyword == "foreach" || keyword == "protected" || keyword == "ulong" ||
              keyword == "checked" || keyword == "goto" || keyword == "public" ||
              keyword == "unchecked" || keyword == "class" || keyword == "if" ||
              keyword == "readonly" || keyword == "unsafe" || keyword == "const" ||
              keyword == "implicit" || keyword == "ref" || keyword == "ushort" ||
              keyword == "continue" || keyword == "in" || keyword == "return" ||
              keyword == "using" || keyword == "int" || keyword == "decimal" ||
              keyword == "sbyte" || keyword == "virtual" || keyword == "default" ||
              keyword == "interface" || keyword == "sealed" || keyword == "volatile" ||
              keyword == "delegate" || keyword == "internal" || keyword == "short" ||
              keyword == "void" || keyword == "do" || keyword == "is" || keyword == "sizeof" ||
              keyword == "while" || keyword == "double" || keyword == "lock" ||
              keyword == "stackalloc" || keyword == "else" || keyword == "long" ||
              keyword == "static" || keyword == "enum" || keyword == "namespace" ||
              keyword == "string" || keyword == "partial" || keyword == "where" || keyword == "dynamic" ||
              keyword == "yield" || keyword == "orderby" || keyword == "value")
            {
                return true;
            }
            return false;
        }
    }
}
