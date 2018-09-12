namespace TokenIcer
{
    public interface ITokenIcerLanguage
    {
        string AddToken(string identifier, string regEx);
        string GetCommentIdentifier();
        string GetXmlCommentIdentifier();
        string CreateEnum(string identifier, int num, bool lastEnum);
        string GetSkeletonCode();
        int GetIndentWidth(int partNum);
    }
}
