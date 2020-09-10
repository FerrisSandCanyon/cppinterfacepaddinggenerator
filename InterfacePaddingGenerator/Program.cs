using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePaddingGenerator
{
    public static class Program
    {
        /// <summary>
        /// version in numeric
        /// </summary>
        public static readonly int[] Version = { 0, 0, 1 };

        /// <summary>
        /// Version in string
        /// </summary>
        public static readonly string VersionString = $"{Version[0]}.{Version[1]}.{Version[2]}";

        /// <summary>
        /// Default title for the main form
        /// </summary>
        public static readonly string DefaultTitle = "C++ Interface Padding Generator";

        /// <summary>
        /// Path to the current IPG file loaded
        /// </summary>
        public static string CurrentFile = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FMain());
        }
    }
}
