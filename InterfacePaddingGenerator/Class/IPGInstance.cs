using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IPG.Class
{
    public class IPGInstance
    {
        /// <summary>
        /// Date and Time when this instance was last modified
        /// </summary>
        public DateTime DateLastModified = DateTime.Now;

        /// <summary>
        /// Name of the interface class
        /// </summary>
        public string InterfaceName = "";

        /// <summary>
        /// Number of virtual function padding
        /// </summary>
        public int PaddingCount = 0;

        /// <summary>
        /// Prefix to the virtual funtion padding name
        /// </summary>
        public string PaddingFunctionPrefix = "";

        /// <summary>
        /// Path to the output file
        /// </summary>
        public string OutputFile = "";

        /// <summary>
        /// Non destructive write option
        /// </summary>
        public bool NonDestructive = true;

        /// <summary>
        /// No "I" perfix on interface class name option
        /// </summary>
        public bool NoPrefix = false;

        /// <summary>
        /// List of defined interface functions
        /// int    = vtable index
        /// string = interface function
        /// </summary>
        public List<Class.InterfaceFunction> DefinedFunctions = new List<Class.InterfaceFunction> { };
    }
}