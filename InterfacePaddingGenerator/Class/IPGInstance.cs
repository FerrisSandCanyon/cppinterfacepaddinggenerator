﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterfacePaddingGenerator.Class
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
        public int PaddingSize = 0;

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
        bool NonDestructive = true;

        /// <summary>
        /// No "I" perfix on interface class name option
        /// </summary>
        bool NoPrefix = false;

        /// <summary>
        /// List of defined interface functions
        /// int    = vtable index
        /// string = interface function
        /// </summary>
        public Dictionary<int, string> DefinedFunctions = new Dictionary<int, string> { };

        [JsonIgnore]
        /// <summary>
        /// 
        /// </summary>
        public ListViewItem LVIInstance = null;
    }
}