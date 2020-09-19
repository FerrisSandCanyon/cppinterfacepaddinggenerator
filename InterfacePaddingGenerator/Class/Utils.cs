using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG.Utils
{
    /// <summary>
    /// Utility class containing values
    /// </summary>
    public static class Values
    {
        /// <summary>
        /// An array of chars that are invalid as a file path
        /// </summary>
        public static readonly char[] InvalidFilePath = Path.GetInvalidFileNameChars().Concat(Path.GetInvalidPathChars()).ToArray();
    }
}
