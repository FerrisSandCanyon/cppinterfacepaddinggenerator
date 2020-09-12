using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void FunctionWindow_Load(object sender, EventArgs e)
        {
            if (Mode == FWMode.EDIT && (Program.CurrentInstance == null || !Program.CurrentInstance.DefinedFunctions.ContainsKey(IndexToEdit)))
            {
                MessageBox.Show("A non existant key index was passed to FunctionWindow's constuctor. Please report this issue in the Github's repository with details to what might have caused this.\n\nKey index: " + IndexToEdit, "Invalid key index", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
    }
}
