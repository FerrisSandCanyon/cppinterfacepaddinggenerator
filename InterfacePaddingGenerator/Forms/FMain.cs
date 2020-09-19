//#define DISABLE_UPDATE_CHECK

// TODO: implement shortcut keys

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IPG.Extensions;

namespace IPG.Forms
{
    public partial class FMain : Form
    {
        public FMain(string LoadIPGPath)
        {
            InitializeComponent();
            // Load IPG File after form creation to obtain direct access to FMain's controls
            if (!LoadIPGPath.IsNullOrWhitespace() && Path.GetExtension(LoadIPGPath) == "ipg")
            {
                // Load IPG File
            }
        }

        /// <summary>
        /// Automatically set the title appending the currently opened ipg file
        /// </summary>
        public void SetTitle()
        {
            this.Text = Program.DefaultTitle + " - " + Path.GetFileName(Program.CurrentFile ?? "Untitled");
        }

        /// <summary>
        /// Loads an IPG instance to the UI
        /// </summary>
        /// <param name="instance">An instance of IPG</param>
        public void LoadIPGToUI(in Class.IPGInstance instance)
        {
            tbInterfaceName.Text     = instance.InterfaceName;
            tbFunctionCount.Text      = instance.FunctionCount.ToString();
            tbFunctionPrefix.Text    = instance.PaddingFunctionPrefix;
            cbNonDestructive.Checked = instance.NonDestructive;
            tbOutFile.Text           = instance.OutputFile;

            lvFunctions.Items.Clear();
            foreach (Class.InterfaceFunction ifacefn in instance.DefinedFunctions)
            {
                ifacefn.LVIInstance = new ListViewItem(ifacefn.Index.ToString());
                ifacefn.LVIInstance.SubItems.Add(ifacefn.FunctionSignature);
                lvFunctions.Items.Add(ifacefn.LVIInstance);
            }
        }

        /// <summary>
        /// Loads the UI values to the IPG Instance
        /// </summary>
        /// <returns>[bool] Returns true if successful, false otherwise</returns>
        /// <remarks>I forgot i made this function</remarks>
        public bool LoadUIToIPG()
        {
            // TODO: sanity check for class name
            int idx_function_count = -1;
            if (tbInterfaceName.Text.IsNullOrWhitespace() || tbFunctionCount.Text.IsNullOrWhitespace() || tbFunctionPrefix.Text.IsNullOrWhitespace() // Check for null strings or whitespace
            || !int.TryParse(tbFunctionCount.Text, out idx_function_count) // Parse the index count
            ||  Program.CurrentInstance.DefinedFunctions.FirstOrDefault(x => x.Index > idx_function_count) != null // Check for invalid padding count, padding count should be more than or equal to the highest defined index
            ) {
                MessageBox.Show("Invalid values!", "IPG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Program.CurrentInstance.InterfaceName         = tbInterfaceName.Text;
            Program.CurrentInstance.PaddingFunctionPrefix = tbFunctionPrefix.Text;
            Program.CurrentInstance.FunctionCount         = idx_function_count;
            Program.CurrentInstance.NonDestructive        = cbNonDestructive.Checked;

            return true;
        }

        /// <summary>
        /// Helper function to add an InterfaceFunction to the table
        /// </summary>
        public void TableAdd(Class.InterfaceFunction _if)
        {
            lvFunctions.Items.Add(_if.LVIInstance);
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            #if DISABLE_UPDATE_CHECK
                lblVer.IsLink = false;
            #endif

            #if !DEBUG
                cbNonDestructive.Visible = false;
            #endif

            lblVer.Text = "Version: " + Program.VersionString; // Set version
            SetTitle();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // New
                case Keys.Control | Keys.N:
                {
                    miNew_Click(miNew, null);
                    return true;
                }

                // Open
                case Keys.Control | Keys.O:
                {
                    miOpen_Click(miOpen, null);
                    return true;
                }

                // Save
                case Keys.Control | Keys.S:
                {
                    miSave_Click(miSave, null);
                    return true;
                }

                // Generate
                case Keys.Control | Keys.G:
                {
                    miGenerate_Click(miGenerate, null);
                    return true;
                }

                // Add
                case Keys.Control | Keys.A:
                {
                    miAdd_Click(miAdd, null);
                    return true;
                }

                // Remove
                case Keys.Delete:
                {
                    miRemove_Click(miRemove, null);
                    return true;
                }

                // Edit
                case Keys.Control | Keys.E:
                {
                    miEdit_Click(miEdit, null);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            // ========================================================================
                "Automatically generates function padding for C++ interface classes\n\n" +
                "[Non destructive] - When checked IPG analyzes the file and only overwrites virtual functions leaving custom functions, includes, comments, inherits, etc... untouched.\n\n" +
                "Icons made by iconixar, kiranshastry from www.flaticon.com\n\n" +
                "This software is licensed under MIT and is fully a FOSS\n\n" +
                "Would you like to open the project's Github page? github.com/ferrissandcanyon/cppinterfacepaddinggenerator"
            // ========================================================================
            , Program.DefaultTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start("https://github.com/ferrissandcanyon/cppinterfacepaddinggenerator");
            }
        }

        private void lblVer_Click(object sender, EventArgs e)
        {
            #if !DISABLE_UPDATE_CHECK
            
            #else
            MessageBox.Show("Update checks has been removed from this build.", Program.DefaultTitle);
            #endif
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            new FunctionWindow().ShowDialog();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            if (lvFunctions.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a single item to edit.", "Edit interface function", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int _idx = -1;
            if (!int.TryParse(lvFunctions.SelectedItems[0].SubItems[0].Text, out _idx))
            {
                MessageBox.Show("Invalid index.", "Edit interface function", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new FunctionWindow(_idx).ShowDialog();
        }

        private void miRemove_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection sel = lvFunctions.SelectedItems;

            if (sel.Count < 1)
            {
                MessageBox.Show("Select atleast 1 item to remove!", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem lvi in sel)
            {
                Program.CurrentInstance.DefinedFunctions.RemoveAll(x => x.Index.ToString() == lvi.SubItems[0].Text);
                lvi.Remove();
            }
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            Program.CurrentInstance = new Class.IPGInstance();
            Program.CurrentFile     = null;

            LoadIPGToUI(Program.CurrentInstance);
            SetTitle();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            // Create a open file dialog and load it
            using (OpenFileDialog _ofd = new OpenFileDialog())
            {
                _ofd.Filter = "IPG File (*.ipg) | *.ipg";
                _ofd.Multiselect = false;

                if (_ofd.ShowDialog() != DialogResult.OK)
                    return;

                if (!Utils.IPGInstance.LoadFromFileAndSetup(_ofd.FileName))
                {
                    MessageBox.Show($"Failed to load {_ofd.FileName}!", "Load IPG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.CurrentFile = _ofd.FileName;
                Program.FormMain.SetTitle();
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            bool   newSave = false;               // Tracks if the save is a new file
            string path    = Program.CurrentFile; // Load the save path

            // Verify path and opt for save path if necessary
            if (path == null || !File.Exists(path))
            {
                using (SaveFileDialog _sfd = new SaveFileDialog())
                {
                    _sfd.Filter = "IPG File (*.ipg) | *.ipg";

                    if (_sfd.ShowDialog() != DialogResult.OK)
                        return;

                    path    = _sfd.FileName;
                    newSave = true;
                }
            }

            // Save the file. Prompt for new file otherwise automatically overwrite
            if (!Program.CurrentInstance.SaveToFile(path, newSave ? Utils.IPGInstance.WriteMode.PROMPT_USER : Utils.IPGInstance.WriteMode.OVERWRITE))
            {
                MessageBox.Show($"Failed to save {path}!", "Save IPG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set values if its a new file
            if (newSave)
            {
                Program.CurrentFile = path;
                Program.FormMain.SetTitle();
            }
        }

        private void tbInterfaceName_TextChanged(object sender, EventArgs e)
        {
            Program.CurrentInstance.InterfaceName = ((TextBox)sender).Text;
        }

        private void tbPaddingCount_TextChanged(object _sender, EventArgs e)
        {
            TextBox sender = ((TextBox)_sender);

            // Automatically assign 0 if textbox is empty and set to -1 if parsing is required
            int idx_function_cout = sender.Text.IsNullOrWhitespace() ? 0 : -1;

            // Only parse when set to -1
            if (idx_function_cout == -1
            && (!int.TryParse(sender.Text, out idx_function_cout) || idx_function_cout < 0) || Program.CurrentInstance.DefinedFunctions.FirstOrDefault(x => x.Index > idx_function_cout) != null)
            {
                MessageBox.Show("Invalid value for Function count", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sender.Text = (Program.CurrentInstance.FunctionCount = Program.CurrentInstance.DefinedFunctions.HighestIndex()).ToString();
                return;
            }

            Program.CurrentInstance.FunctionCount = idx_function_cout;
        }

        private void tbFunctionPrefix_TextChanged(object sender, EventArgs e)
        {
            Program.CurrentInstance.PaddingFunctionPrefix = ((TextBox)sender).Text;
        }

        private void cbNonDestructive_CheckedChanged(object sender, EventArgs e)
        {
            Program.CurrentInstance.NonDestructive = ((CheckBox)sender).Checked;
        }

        private void miSetOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog _sfd = new SaveFileDialog())
            {
                _sfd.Filter = "C++ Header File (*.h, *.hpp) | *.h;*.hpp ";
                
                if (_sfd.ShowDialog() != DialogResult.OK)
                    return;

                tbOutFile.Text =  Program.CurrentInstance.OutputFile = _sfd.FileName;
            }
        }

        private void miGenerate_Click(object sender, EventArgs e)
        {
            new Forms.FPreview().ShowDialog();
        }
    }
}
