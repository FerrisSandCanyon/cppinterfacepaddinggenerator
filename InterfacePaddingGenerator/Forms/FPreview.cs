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

            rtbPreview.Text = Program.CurrentInstance.NonDestructive ? Program.CurrentInstance.GenerateDynamic() : Program.CurrentInstance.GenerateStatic();
            cbCloseOnWrite.Checked = Program.CurrentInstance.CloseOnWrite;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!Program.CurrentInstance.GenerateWrite(rtbPreview.Text))
            {
                MessageBox.Show("Failed to write to file!", "Write to file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Interface class written!", "Write to file", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Program.CurrentInstance.CloseOnWrite)
                this.Close();
        }

        private void cbCloseOnWrite_CheckedChanged(object sender, EventArgs e)
        {
            Program.CurrentInstance.CloseOnWrite = ((CheckBox)sender).Checked;
        }
    }
}
