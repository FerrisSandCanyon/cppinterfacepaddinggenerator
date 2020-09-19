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
            btnWrite.Enabled = !Program.CurrentInstance.OutputFile.IsNullOrWhitespace();
            rtbPreview.Text = Program.CurrentInstance.GenerateStatic(); 
        }
    }
}
