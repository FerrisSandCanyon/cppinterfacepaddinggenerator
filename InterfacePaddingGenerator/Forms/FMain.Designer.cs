using System.Windows.Forms;

namespace InterfacePaddingGenerator.Forms
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvFunctions = new System.Windows.Forms.ListView();
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFunction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsddFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ddCustomInterface = new System.Windows.Forms.ToolStripDropDownButton();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblVer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFunctionPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNonDestructive = new System.Windows.Forms.CheckBox();
            this.cbNoPrefix = new System.Windows.Forms.CheckBox();
            this.tbPaddingCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInterfaceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvFunctions);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defined Interface Functions";
            // 
            // lvFunctions
            // 
            this.lvFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lvFunctions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIndex,
            this.chFunction});
            this.lvFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFunctions.ForeColor = System.Drawing.Color.White;
            this.lvFunctions.FullRowSelect = true;
            this.lvFunctions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFunctions.HideSelection = false;
            this.lvFunctions.Location = new System.Drawing.Point(3, 18);
            this.lvFunctions.Name = "lvFunctions";
            this.lvFunctions.Size = new System.Drawing.Size(809, 221);
            this.lvFunctions.TabIndex = 0;
            this.lvFunctions.UseCompatibleStateImageBehavior = false;
            this.lvFunctions.View = System.Windows.Forms.View.Details;
            // 
            // chIndex
            // 
            this.chIndex.Text = "idx";
            this.chIndex.Width = 29;
            // 
            // chFunction
            // 
            this.chFunction.Text = "Function";
            this.chFunction.Width = 686;
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddFile,
            this.ddCustomInterface,
            this.toolStripSeparator1,
            this.lblVer,
            this.toolStripSeparator2,
            this.btnAbout});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(839, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsddFile
            // 
            this.tsddFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miSave,
            this.miGenerate,
            this.miSetOutput});
            this.tsddFile.ForeColor = System.Drawing.Color.Black;
            this.tsddFile.Image = global::InterfacePaddingGenerator.Properties.Resources.mainicon;
            this.tsddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddFile.Name = "tsddFile";
            this.tsddFile.Size = new System.Drawing.Size(54, 22);
            this.tsddFile.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(336, 22);
            this.miOpen.Text = "Open Interface Padding Generator (*.ipg) File";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(336, 22);
            this.miSave.Text = "Save as an Interface Padding Generator (*.ipg) File";
            // 
            // miGenerate
            // 
            this.miGenerate.Name = "miGenerate";
            this.miGenerate.Size = new System.Drawing.Size(336, 22);
            this.miGenerate.Text = "Generate Interface";
            // 
            // miSetOutput
            // 
            this.miSetOutput.Name = "miSetOutput";
            this.miSetOutput.Size = new System.Drawing.Size(336, 22);
            this.miSetOutput.Text = "Set output file";
            // 
            // ddCustomInterface
            // 
            this.ddCustomInterface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miRemove,
            this.miEdit});
            this.ddCustomInterface.ForeColor = System.Drawing.Color.Black;
            this.ddCustomInterface.Image = global::InterfacePaddingGenerator.Properties.Resources.edit;
            this.ddCustomInterface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddCustomInterface.Name = "ddCustomInterface";
            this.ddCustomInterface.Size = new System.Drawing.Size(127, 22);
            this.ddCustomInterface.Text = "Custom Interface";
            // 
            // miAdd
            // 
            this.miAdd.Image = global::InterfacePaddingGenerator.Properties.Resources.plus;
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(180, 22);
            this.miAdd.Text = "Add";
            // 
            // miRemove
            // 
            this.miRemove.Image = global::InterfacePaddingGenerator.Properties.Resources.error;
            this.miRemove.Name = "miRemove";
            this.miRemove.Size = new System.Drawing.Size(180, 22);
            this.miRemove.Text = "Remove";
            // 
            // miEdit
            // 
            this.miEdit.Image = global::InterfacePaddingGenerator.Properties.Resources.edit;
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(180, 22);
            this.miEdit.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblVer
            // 
            this.lblVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblVer.ForeColor = System.Drawing.Color.Red;
            this.lblVer.IsLink = true;
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(75, 22);
            this.lblVer.Text = "Version: 0.0.0";
            this.lblVer.Click += new System.EventHandler(this.lblVer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAbout
            // 
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Image = global::InterfacePaddingGenerator.Properties.Resources.info;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbFunctionPrefix);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbNonDestructive);
            this.groupBox2.Controls.Add(this.cbNoPrefix);
            this.groupBox2.Controls.Add(this.tbPaddingCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbInterfaceName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface";
            // 
            // tbFunctionPrefix
            // 
            this.tbFunctionPrefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbFunctionPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFunctionPrefix.ForeColor = System.Drawing.Color.White;
            this.tbFunctionPrefix.Location = new System.Drawing.Point(434, 21);
            this.tbFunctionPrefix.Name = "tbFunctionPrefix";
            this.tbFunctionPrefix.Size = new System.Drawing.Size(153, 22);
            this.tbFunctionPrefix.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Function padding prefix:";
            // 
            // cbNonDestructive
            // 
            this.cbNonDestructive.AutoSize = true;
            this.cbNonDestructive.Checked = true;
            this.cbNonDestructive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNonDestructive.Location = new System.Drawing.Point(451, 52);
            this.cbNonDestructive.Name = "cbNonDestructive";
            this.cbNonDestructive.Size = new System.Drawing.Size(107, 17);
            this.cbNonDestructive.TabIndex = 3;
            this.cbNonDestructive.Text = "Non destructive";
            this.cbNonDestructive.UseVisualStyleBackColor = true;
            // 
            // cbNoPrefix
            // 
            this.cbNoPrefix.AutoSize = true;
            this.cbNoPrefix.Location = new System.Drawing.Point(321, 52);
            this.cbNoPrefix.Name = "cbNoPrefix";
            this.cbNoPrefix.Size = new System.Drawing.Size(124, 17);
            this.cbNoPrefix.TabIndex = 2;
            this.cbNoPrefix.Text = "Dont prefix with \"I\"";
            this.cbNoPrefix.UseVisualStyleBackColor = true;
            // 
            // tbPaddingCount
            // 
            this.tbPaddingCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbPaddingCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPaddingCount.ForeColor = System.Drawing.Color.White;
            this.tbPaddingCount.Location = new System.Drawing.Point(134, 50);
            this.tbPaddingCount.Name = "tbPaddingCount";
            this.tbPaddingCount.Size = new System.Drawing.Size(153, 22);
            this.tbPaddingCount.TabIndex = 5;
            this.tbPaddingCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of functions:";
            // 
            // tbInterfaceName
            // 
            this.tbInterfaceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbInterfaceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInterfaceName.ForeColor = System.Drawing.Color.White;
            this.tbInterfaceName.Location = new System.Drawing.Point(134, 21);
            this.tbInterfaceName.Name = "tbInterfaceName";
            this.tbInterfaceName.Size = new System.Drawing.Size(153, 22);
            this.tbInterfaceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interface name:";
            // 
            // tbOutFile
            // 
            this.tbOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbOutFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutFile.ForeColor = System.Drawing.Color.White;
            this.tbOutFile.Location = new System.Drawing.Point(81, 364);
            this.tbOutFile.Name = "tbOutFile";
            this.tbOutFile.ReadOnly = true;
            this.tbOutFile.Size = new System.Drawing.Size(746, 22);
            this.tbOutFile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output file:";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(839, 396);
            this.Controls.Add(this.tbOutFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C++ Interface Padding Generator - Untitled";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvFunctions;
        private System.Windows.Forms.ColumnHeader chIndex;
        private System.Windows.Forms.ColumnHeader chFunction;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsddFile;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripDropDownButton ddCustomInterface;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miRemove;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbInterfaceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNoPrefix;
        private System.Windows.Forms.ToolStripMenuItem miGenerate;
        private System.Windows.Forms.TextBox tbPaddingCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbNonDestructive;
        private System.Windows.Forms.TextBox tbOutFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem miSetOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblVer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.TextBox tbFunctionPrefix;
        private System.Windows.Forms.Label label4;
    }
}

