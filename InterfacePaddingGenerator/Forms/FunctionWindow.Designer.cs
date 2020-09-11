namespace IPG.Forms
{
    partial class FunctionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionWindow));
            this.tbFunctionSignature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFunctionSignature
            // 
            this.tbFunctionSignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbFunctionSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFunctionSignature.ForeColor = System.Drawing.Color.White;
            this.tbFunctionSignature.Location = new System.Drawing.Point(122, 40);
            this.tbFunctionSignature.Name = "tbFunctionSignature";
            this.tbFunctionSignature.Size = new System.Drawing.Size(263, 22);
            this.tbFunctionSignature.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Function Signature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Index:";
            // 
            // tbIndex
            // 
            this.tbIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIndex.ForeColor = System.Drawing.Color.White;
            this.tbIndex.Location = new System.Drawing.Point(122, 12);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(263, 22);
            this.tbIndex.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(310, 68);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // FunctionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(400, 103);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFunctionSignature);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FunctionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface Function";
            this.Load += new System.EventHandler(this.FunctionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFunctionSignature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnConfirm;
    }
}