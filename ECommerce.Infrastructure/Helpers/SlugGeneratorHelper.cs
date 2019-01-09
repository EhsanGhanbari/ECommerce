using System.Text.RegularExpressions;

namespace ECommerce.Infrastructure.Helpers
{
    /// <summary>
    /// Slug generator for Blog and news to be SEO friendly
    /// </summary>
    public static class SlugGeneratorHelper
    {
        public static string GenerateSlug(this string phrase, int maxLength = 100)
        {
            string str = phrase.ToLower();
            // invalid chars, make into spaces
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces/hyphens into one space       
            str = Regex.Replace(str, @"[\s-]+", " ").Trim();
            // cut and trim it
            str = str.Substring(0, str.Length <= maxLength ? str.Length : maxLength).Trim();
            // hyphens
            str = Regex.Replace(str, @"\s", "-");

            return str;
        }
    }
}