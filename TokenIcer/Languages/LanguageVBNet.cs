using System.IO;
using System.Reflection;

namespace TokenIcer.Languages
{
    public class LanguageVBNet : ITokenIcerLanguage
    {
        public string AddToken(string identifier, string regEx)
        {
            regEx = regEx.Replace("\"", "\"\"");
            if (IsVBKeyword(identifier))
                identifier = "[" + identifier + "]";
            return "_tokens.Add(Tokens." + identifier + ", \"" + regEx + "\")";
        }

        public string GetCommentIdentifier()
        {
            return "'";
        }

        public string GetXmlCommentIdentifier()
        {
            return "'''";
        }

        public string CreateEnum(string identifier, int num, bool lastEnum)
        {
            if (IsVBKeyword(identifier))
                identifier = "[" + identifier + "]";
            return identifier + "=" + num.ToString();
        }

        public string GetSkeletonCode()
        {
            StreamReader textStreamReader;
            Assembly assembly = Assembly.GetExecutingAssembly();

            try
            {
                textStreamReader =
                    new StreamReader(assembly.GetManifestResourceStream("TokenIcer.LanguageFiles.VBNet.txt"));
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

        private bool IsVBKeyword(string keyword)
        {
            keyword = keyword.ToUpper();
            if (keyword == "ADDHANDLER" || keyword == "ADDRESSOF" || keyword == "ALIAS" ||
           keyword == "AND" || keyword == "ANDALSO" || keyword == "AS" || keyword == "BYREF" ||
           keyword == "BOOLEAN" || keyword == "BYTE" || keyword == "BYVAL" || keyword == "CALL" ||
           keyword == "CASE" || keyword == "CATCH" || keyword == "CBOOL" || keyword == "CBYTE" ||
           keyword == "CCHAR" || keyword == "CDATE" || keyword == "CDEC" || keyword == "CDBL" ||
           keyword == "CHAR" || keyword == "CINT" || keyword == "CLASS" || keyword == "CLNG" ||
           keyword == "COBJ" || keyword == "CONST" || keyword == "CONTINUE" || keyword == "CSBYTE" ||
           keyword == "CSHORT" || keyword == "CSNG" || keyword == "CSTR" || keyword == "CTYPE" ||
           keyword == "CUINT" || keyword == "CULNG" || keyword == "CUSHORT" || keyword == "DATE" ||
           keyword == "DECIMAL" || keyword == "DECLARE" || keyword == "DEFAULT" || keyword == "DELEGATE" ||
           keyword == "DIM" || keyword == "DIRECTCAST" || keyword == "DOUBLE" || keyword == "DO" || keyword == "EACH" ||
           keyword == "ELSE" || keyword == "ELSEIF" || keyword == "END" || keyword == "ENDIF" || keyword == "ENUM" ||
           keyword == "ERASE" || keyword == "ERROR" || keyword == "EVENT" || keyword == "EXIT" ||
           keyword == "FALSE" || keyword == "FINALLY" || keyword == "FOR" || keyword == "FRIEND" ||
           keyword == "FUNCTION" || keyword == "GET" || keyword == "GETTYPE" || keyword == "GLOBAL" ||
           keyword == "GOSUB" || keyword == "GOTO" || keyword == "HANDLES" || keyword == "IF" ||
           keyword == "IMPLEMENTS" || keyword == "IMPORTS" || keyword == "IN" || keyword == "INHERITS" ||
           keyword == "INTEGER" || keyword == "INTERFACE" || keyword == "IS" || keyword == "ISNOT" ||
           keyword == "LET" || keyword == "LIB" || keyword == "LIKE" || keyword == "LONG" ||
           keyword == "LOOP" || keyword == "ME" || keyword == "MOD" || keyword == "MODULE" ||
           keyword == "MUSTINHERIT" || keyword == "MUSTOVERRIDE" || keyword == "MYBASE" ||
           keyword == "MYCLASS" || keyword == "NAMESPACE" || keyword == "NARROWING" ||
           keyword == "NEW" || keyword == "NEXT" || keyword == "NOT" || keyword == "NOTHING" ||
           keyword == "NOTINHERITABLE" || keyword == "NOTOVERRIDABLE" || keyword == "OBJECT" ||
           keyword == "ON" || keyword == "OF" || keyword == "OPERATOR" || keyword == "OPTION" ||
           keyword == "OPTIONAL" || keyword == "OR" || keyword == "ORELSE" || keyword == "OVERLOADS" ||
           keyword == "OVERRIDABLE" || keyword == "OVERRIDES" || keyword == "PARAMARRAY" || keyword == "PARTIAL" ||
           keyword == "PRIVATE" || keyword == "PROPERTY" || keyword == "PROTECTED" || keyword == "PUBLIC" ||
           keyword == "RAISEEVENT" || keyword == "READONLY" || keyword == "REDIM" || keyword == "REM" ||
           keyword == "REMOVEHANDLER" || keyword == "RESUME" || keyword == "RETURN" || keyword == "SBYTE" ||
           keyword == "SELECT" || keyword == "SET" || keyword == "SHADOWS" || keyword == "SHARED" ||
           keyword == "SHORT" || keyword == "SINGLE" || keyword == "STATIC" || keyword == "STEP" ||
           keyword == "STOP" || keyword == "STRING" || keyword == "STRUCTURE" || keyword == "SUB" ||
           keyword == "SYNCLOCK" || keyword == "THEN" || keyword == "THROW" || keyword == "TO" ||
           keyword == "TRUE" || keyword == "TRY" || keyword == "TRYCAST" || keyword == "TYPEOF" ||
           keyword == "WEND" || keyword == "VARIANT" || keyword == "UINTEGER" || keyword == "ULONG" ||
           keyword == "USHORT" || keyword == "USING" || keyword == "WHEN" || keyword == "WHILE" ||
           keyword == "WIDENING" || keyword == "WITH" || keyword == "WITHEVENTS" || keyword == "WRITEONLY" ||
           keyword == "XOR" || keyword == "#CONST" || keyword == "#ELSE" || keyword == "#ELSEIF" || keyword == "#END" || keyword == "#IF")
            {
                return true;
            }
            return false;
        }
    }
}
