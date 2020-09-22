using System;
using System.Windows.Forms;
using IPG.Extensions;

namespace IPG.Forms
{
    public partial class FPreview : Form
    {
        public FPreview()
        {
            InitializeComponent();
        }

        private void FPreview_Load(object sender, EventArgs e)
        {
            if (btnWrite.Enabled = !Program.CurrentInstance.OutputFile.IsNullOrWhitespace())
                this.Text += " - " + Program.CurrentInstance.ProperOutFile();

            rtbPreview.Text = Program.CurrentInstance.GenerateStatic(); 
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
