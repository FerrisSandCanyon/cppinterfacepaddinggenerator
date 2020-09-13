using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IPG.Extensions;

namespace IPG.Forms
{
    public partial class FunctionWindow : Form
    {
        /// <summary>
        /// Enumerator for the mode of the current instace of FunctionWindow
        /// </summary>
        private enum FWMode
        {
            UNDEFINED,
            ADD,
            EDIT
        };

        /// <summary>
        /// Current mode of the current FunctionWindow instance
        /// </summary>
        private FWMode Mode = FWMode.UNDEFINED;

        /// <summary>
        /// Index to edit when in edit mode
        /// </summary>
        private int IndexToEdit = -1;

        /// <summary>
        /// Constructor for Adding a new interface function
        /// </summary>
        public FunctionWindow()
        {
            InitializeComponent();
            btnConfirm.Text = "Add";
            this.Text = "Add an " + this.Text;
            IndexToEdit = -1;
            Mode = FWMode.ADD;
            cbAddAnother.Enabled = true;
        }

        /// <summary>
        /// Constructor for editing an existing interface function
        /// </summary>
        /// <param name="idx">Index to edit</param>
        public FunctionWindow(int idx)
        {
            InitializeComponent();
            btnConfirm.Text = "Edit";
            this.Text = "Edit an " + this.Text;
            IndexToEdit = idx;
            Mode = FWMode.EDIT;
            cbAddAnother.Enabled = false;
            Class.InterfaceFunction _selectedFunction = Program.CurrentInstance.DefinedFunctions.ElementAt(idx);
            tbIndex.Text = _selectedFunction.Index.ToString();
            tbFunctionSignature.Text = _selectedFunction.FunctionSignature;
        }

        private void FunctionWindow_Load(object sender, EventArgs e)
        {
            if (Program.CurrentInstance == null || (Mode == FWMode.EDIT && !Program.CurrentInstance.DefinedFunctions.ContainsIndex(IndexToEdit)) )
            {
                MessageBox.Show("A non existant key index was passed to FunctionWindow's constuctor. Please report this issue in the Github's repository with details to what might have caused this.\n\nKey index: " + IndexToEdit, "Invalid key index", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool isSuccess = true; // Set to false to prevent the finalization routine from getting executed
            int _idx       = -1;   // Parsed index value
            
            // Check for blank input
            if (tbIndex.Text.IsNullOrWhitespace() || tbFunctionSignature.Text.IsNullOrWhitespace())
            {
                MessageBox.Show("Input field is empty!");
                return;
            }

            // Parse the index
            if (!int.TryParse(tbIndex.Text, out _idx))
            {
                MessageBox.Show("Invalid index!");
                return;
            }

            switch (Mode)
            {
                case FWMode.ADD:
                {
                    if (Program.CurrentInstance.DefinedFunctions.ContainsIndex(_idx))
                    {
                        MessageBox.Show("This index already exists!");
                        return;
                    }

                    // Create a new InterfaceFunction instance and add it to the list of defined functions
                    Class.InterfaceFunction _ifinst = new Class.InterfaceFunction(_idx, tbFunctionSignature.Text, new ListViewItem(tbIndex.Text));
                    _ifinst.LVIInstance.SubItems.Add(tbFunctionSignature.Text);
                    Program.CurrentInstance.DefinedFunctions.Add(_ifinst);
                    Program.FormMain.TableAdd(_ifinst);

                    break;
                }

                case FWMode.EDIT:
                {
                    break;
                }
            }

            // Return when unsuccesful
            if (!isSuccess)
                return;

            string[] message = { "", "Added", "Edited" };
            MessageBox.Show($"Succesfuly {message[(int)Mode]} the interface function!", "Function Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Exit the UI if operation was successful unless in add mode and add another is enabled
            if (Mode == FWMode.EDIT // And is in edit mode
            || (Mode == FWMode.ADD && !cbAddAnother.Checked) // Or in add mode and Add another was not checked)
            ) {
                this.Close();
            }
            else if (Mode == FWMode.ADD && cbAddAnother.Checked) // Handle when add another is enabled in add mode
            {
                tbIndex.Clear();
                tbFunctionSignature.Clear();
            }
        }
    }
}
