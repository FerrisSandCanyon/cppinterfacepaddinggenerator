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
        /// <param name="instance">Instance of an interface function</param>
        /// <param name="FunctionSignaure">Function signature to check if it exists</param>
        /// <returns>True if it exists, otherwise false</returns>
        public static bool ContainsFunctionSignature(this List<Class.InterfaceFunction> instance, string FunctionSignaure)
        {
            return instance.FirstOrDefault(x => x.FunctionSignature == FunctionSignaure) != null;
        }

        /// <summary>
        /// Obtains the highest index in the Defined functions
        /// </summary>
        /// <returns>[int] The highest index in the defined functions, -1 if non</returns>
        public static int HighestIndex(this List<Class.InterfaceFunction> instance)
        {
            int highest = -1;
            foreach (Class.InterfaceFunction ifn in instance)
                if (ifn.Index > highest)
                    highest = ifn.Index;

            return highest;
        }
    }
}
