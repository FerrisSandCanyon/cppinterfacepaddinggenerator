using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG.Extensions
{
    public static class IPGInstanceExtension
    {
        /// <summary>
        /// Utility function for checking if Defined Functions contains the index
        /// </summary>
        /// <param name="instance">Instance of an interface function</param>
        /// <param name="Index">Index to check if it exists</param>
        /// <returns>True if it exists, otherwise false</returns>
        public static bool ContainsIndex(this List<Class.InterfaceFunction> instance, int Index)
        {
            return instance.FirstOrDefault(x => x.Index == Index) != null;
        }

        /// <summary>
        /// Utllity function for checking if Defined Functions contains the function signature
        /// </summary>
        /// <param name="instace">Instance of an interface function</param>
        /// <param name="FunctionSignaure">Function signature to check if it exists</param>
        /// <returns>True if it exists, otherwise false</returns>
        public static bool ContainsFunctionSignature(this List<Class.InterfaceFunction> instace, string FunctionSignaure)
        {
            return instace.FirstOrDefault(x => x.FunctionSignature == FunctionSignaure) != null;
        }
    }
}
