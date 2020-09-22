﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using IPG.Extensions;
using System.Windows.Forms;
using System.Linq;

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
        public int FunctionCount = 0;

        /// <summary>
        /// Prefix to the virtual funtion padding name
        /// </summary>
        public string PaddingFunctionPrefix = "pad";

        /// <summary>
        /// Path to the output file
        /// </summary>
        public string OutputFile = "";

        /// <summary>
        /// Non destructive write option
        /// </summary>
        public bool NonDestructive = true;

        /// <summary>
        /// Output file relative to instance option
        /// </summary>
        public bool InstanceRelative = false;

        /// <summary>
        /// List of defined interface functions
        /// </summary>
        public List<Class.InterfaceFunction> DefinedFunctions = new List<Class.InterfaceFunction> { };

        /// <summary>
        /// Verifies that the values for the current instance is ready to generate
        /// </summary>
        /// <returns>[bool] True if values are ok, false otherwise</returns>
        public bool VerifyValues()
        {
            // TODO: Also verify for invalid keywords

            if (InterfaceName.IsNullOrWhitespace()                   // Interface name check
            ||  FunctionCount < 1                                    // Function count check
            // TODO: verify path
            || (InstanceRelative && OutputFile.IsNullOrWhitespace()) // If instance relative is enabled, output file should be provided
            ) {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Generates an interface class based off the current instance
        /// </summary>
        /// <returns></returns>
        public string GenerateStatic()
        {
            string final = 
                $"class {this.InterfaceName}\n" +
                "{\n" +
                "public:";

            for (int idx = 0; idx < this.FunctionCount; idx++)
            {
                string fnstr = null;
                Class.InterfaceFunction ifn = Program.CurrentInstance.DefinedFunctions.FirstOrDefault(x => x.Index == idx);

                fnstr = ifn == null ? $"virtual void {this.PaddingFunctionPrefix}_{idx}(void)" : ifn.FunctionSignature;

                if (!fnstr.StartsWith("virtual"))
                    fnstr = fnstr.Insert(0, "virtual ");

                if (!fnstr.Replace(" ", "").EndsWith("=0;"))
                    fnstr += " = 0;";

                final += $"\n\t{fnstr}";
            }

            final += "\n}";

            return final;
        }

    }
}

namespace IPG.Utils
{
    public static class IPGInstance
    {
        /// <summary>
        /// Enum for the write mode used by the SaveToFile method
        /// </summary>
        public enum WriteMode
        {
            PROMPT_USER,
            OVERWRITE
        }

        /// <summary>
        /// Serializes an IPGInstance class and saves it to the provided destination
        /// </summary>
        /// <param name="instance">An instance of the IPGInstance class</param>
        /// <param name="filepath">File path to save as</param>
        /// <param name="writemode">Writing mode to use</param>
        /// <returns>[bool] Returns true if successful, false otherwise.</returns>
        public static bool SaveToFile(in Class.IPGInstance instance, string filepath, WriteMode writemode)
        {
            // Prompt user for overwrite if applicable
            if (writemode == WriteMode.PROMPT_USER
            &&  File.Exists(filepath)
            &&  MessageBox.Show("The target file already exists! Would you like to overwrite it?", "Save IPG Instance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No
            ) {
                return false;
            }

            // Update the last modified value
            instance.DateLastModified = DateTime.Now;

            // Serialize the IPGInstance
            string serialized = JsonConvert.SerializeObject(instance);
            if (serialized == null)
            {
                MessageBox.Show("JSON serialization returned null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Write the serialized instance
            using (StreamWriter _sw = new StreamWriter(filepath, false))
            {
                _sw.Write(serialized);
                _sw.Close();
            }

            return true;
        }

        /// <summary>
        /// Deserializes an IPGInstance from a file and returns it
        /// </summary>
        /// <param name="filepath">Path to the IPGInstance file to deserialize and load</param>
        /// <returns>A class instance of IPGInstance deserialized from the file path</returns>
        public static Class.IPGInstance LoadFromFile(string filepath)
        {
            // Check for file existance
            if (!File.Exists(filepath))
                return null;

            // Temporarily hold the instance
            Class.IPGInstance instance = null;

            // Read and deserialize the IPGInstance file
            using (StreamReader _sr = new StreamReader(filepath))
            {
                instance = JsonConvert.DeserializeObject<Class.IPGInstance>(_sr.ReadToEnd());
                _sr.Close();
            }

            if (instance == null)
            {
                MessageBox.Show("JSON deserialization returned null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return instance;
        }

        /// <summary>
        /// Wrapper function for LoadFromFile that automatically sets up the UI and associated values
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        /// <remarks>
        /// Wrapper function exists so LoadFromFile can be independent and load IPG files without loading it as the current instance and to ease loading of files
        /// </remarks>
        public static bool LoadFromFileAndSetup(string filepath)
        {
            // Load the IPG file
            Class.IPGInstance instance = LoadFromFile(filepath);

            if (instance == null)
                return false;

            // Load the values
            Program.CurrentInstance = instance;
            Program.CurrentFile = filepath;

            // Update the UI
            Program.FormMain.LoadIPGToUI(instance);
            Program.FormMain.SetTitle();

            return true;
        }
    }
}