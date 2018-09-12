using System.IO;
using System.Reflection;

namespace TokenIcer
{
    public class LanguageFSharp : ITokenIcerLanguage
    {
        public string AddToken(string identifier, string regEx)
        {
            regEx = regEx.Replace("\\", "\\\\").Replace("\"", "\\\"");
            if (IsFSKeyword(identifier))
                identifier = "`" + identifier + "`";
            return "do _tokens.Add(Tokens." + identifier + ", \"" + regEx + "\")";
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
            if (IsFSKeyword(identifier))
                identifier = "`" + identifier + "`";
            return "| " + identifier + " = " + num.ToString();
        }

        public string GetSkeletonCode()
        {
            StreamReader textStreamReader;
            Assembly assembly = Assembly.GetExecutingAssembly();

            try
            {
                textStreamReader =
                    new StreamReader(assembly.GetManifestResourceStream("TokenIcer.LanguageFiles.FSharp.txt"));
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
                return 1;
            return 1;
        }

        private bool IsFSKeyword(string keyword)
        {
            if (keyword == "abstract" || keyword == "and" || keyword == "as" ||
              keyword == "assert" || keyword == "base" || keyword == "begin" ||
              keyword == "class" || keyword == "default" || keyword == "delegate" ||
              keyword == "do" || keyword == "done" || keyword == "downcast" ||
              keyword == "downto" || keyword == "elif" || keyword == "else" ||
              keyword == "end" || keyword == "exception" || keyword == "extern" ||
              keyword == "false" || keyword == "finally" || keyword == "for" ||
              keyword == "fun" || keyword == "function" || keyword == "global" ||
              keyword == "if" || keyword == "in" || keyword == "inherit" ||
              keyword == "inline" || keyword == "interface" || keyword == "internal" ||
              keyword == "lazy" || keyword == "let" || keyword == "match" ||
              keyword == "member" || keyword == "module" || keyword == "mutable" ||
              keyword == "namespace" || keyword == "new" || keyword == "not" ||
              keyword == "null" || keyword == "of" || keyword == "open" ||
              keyword == "or" || keyword == "override" || keyword == "private" ||
              keyword == "public" || keyword == "rec" || keyword == "return" ||
              keyword == "static" || keyword == "struct" || keyword == "then" ||
              keyword == "to" || keyword == "true" || keyword == "try" ||
              keyword == "type" || keyword == "upcast" || keyword == "use" ||
              keyword == "val" || keyword == "void" || keyword == "when" ||
              keyword == "while" || keyword == "with" || keyword == "yield" ||
              keyword == "asr" || keyword == "land" || keyword == "lor" || keyword == "lsl" ||
              keyword == "lsr" || keyword == "lxor" || keyword == "mod" ||
              keyword == "sig" || keyword == "atomic" || keyword == "break" ||
              keyword == "checked" || keyword == "component" || keyword == "const" ||
              keyword == "constraint" || keyword == "constructor" || keyword == "continue" || keyword == "eager" ||
              keyword == "event" || keyword == "external" || keyword == "fixed" || keyword == "functor" ||
              keyword == "include" || keyword == "method" || keyword == "mixin" || keyword == "object" ||
              keyword == "parallel" || keyword == "process" || keyword == "protected" || keyword == "pure" ||
              keyword == "sealed" || keyword == "tailcall" || keyword == "trait" || keyword == "virtual" ||
              keyword == "volatile")
            {
                return true;
            }
            return false;
        }
    }
}
