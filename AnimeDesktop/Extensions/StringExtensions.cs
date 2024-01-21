using System.Text.RegularExpressions;

namespace AnimeDesktop.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveString(this string ruleObject, string pattern)
        {
            if (ruleObject != null) {
               ruleObject = Regex.Replace(ruleObject, pattern, "");
            }

            return ruleObject;
        }
    }
}
