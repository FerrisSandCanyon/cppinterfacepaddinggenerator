﻿//#define DISABLE_UPDATE_CHECK

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace InterfacePaddingGenerator.Forms
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Automatically set the title appending the currently opened ipg file
        /// </summary>
        private void SetTitile()
        {
            this.Text = Program.DefaultTitle + " - " + Path.GetFileName(Program.CurrentFile ?? "Untitled");
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            #if DISABLE_UPDATE_CHECK
                lblVer.IsLink = false;
            #endif

            lblVer.Text = "Version: " + Program.VersionString; // Set version
            SetTitile();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                // ========================================================================
                "Automatically generates function padding for C++ interface classes\n\n" +
                "[Dont prefix with \"I\"] - Disables prefixing the class name with I\n\n" +
                "[Non destructive] - When checked IPG analyzes the file and only overwrites virtual functions leaving custom functions, includes, comments, inherits, etc... untouched.\n\n" +
                "Icons made by iconixar, kiranshastry from www.flaticon.com\n\n" +
                "This software is licensed under MIT and is fully a FOSS\n\n" +
                "Would you like to open the project's Github page? github.com/ferrissandcanyon/cppinterfacepaddinggenerator"
            // ========================================================================
            , Program.DefaultTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Process.Start("https://github.com/ferrissandcanyon/cppinterfacepaddinggenerator");
        }

        private void lblVer_Click(object sender, EventArgs e)
        {
            #if !DISABLE_UPDATE_CHECK
            
            #else
            MessageBox.Show("Update checks has been removed from this build.", Program.DefaultTitle);
            #endif
        }
    }
}
