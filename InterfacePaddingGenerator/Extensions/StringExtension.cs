using System.IO;
using System.Linq;

namespace IPG.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Method extension to string for check if it's null or whitespace
        /// </summary>
        /// <param name="str">string instance</param>
        /// <returns>[bool] Returns true if the string is null or whitesspace, otherwise false</returns>
        public static bool IsNullOrWhitespace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
