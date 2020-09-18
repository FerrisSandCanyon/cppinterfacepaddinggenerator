using System;
using System.Linq;
using System.Windows.Forms;

namespace IPG
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
        public static readonly string DefaultTitle =
        #if DEBUG
            "C++ Interface Padding Generator [debug]";
        #else
            "C++ Interface Padding Generator";
        #endif

        /// <summary>
        /// Path to the current IPG file loaded
        /// </summary>
        public static string CurrentFile = null;

        /// <summary>
        /// Handle to the main form
        /// </summary>
        public static Forms.FMain FormMain = null;

        /// <summary>
        /// Current IPG Instance loaded
        /// </summary>
        public static Class.IPGInstance CurrentInstance = new Class.IPGInstance();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormMain = new Forms.FMain(args.Count() > 0 ? args[0] : null));
        }
    }
}
