using System.Text.RegularExpressions;

namespace AnimeDesktop.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveString(this string ruleObject, string pattern)
        {
            ruleObject = Regex.Replace(ruleObject, pattern, "");
            return ruleObject;
        }
    }
}
