namespace TokenIcer
{
    partial class GenerateClassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlLanguage = new System.Windows.Forms.ComboBox();
            this.chkIncludeComments = new System.Windows.Forms.CheckBox();
            this.btnGenerateClass = new System.Windows.Forms.Button();
            this.chkRuleComments = new System.Windows.Forms.CheckBox();
            this.chkXMLComments = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language:";
            // 
            // ddlLanguage
            // 
            this.ddlLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ddlLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLanguage.FormattingEnabled = true;
            this.ddlLanguage.Items.AddRange(new object[] {
            "C#",
            "VB.NET",
            "F#"});
            this.ddlLanguage.Location = new System.Drawing.Point(70, 20);
            this.ddlLanguage.Name = "ddlLanguage";
            this.ddlLanguage.Size = new System.Drawing.Size(82, 21);
            this.ddlLanguage.TabIndex = 1;
            // 
            // chkIncludeComments
            // 
            this.chkIncludeComments.AutoSize = true;
            this.chkIncludeComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chkIncludeComments.Location = new System.Drawing.Point(12, 47);
            this.chkIncludeComments.Name = "chkIncludeComments";
            this.chkIncludeComments.Size = new System.Drawing.Size(113, 17);
            this.chkIncludeComments.TabIndex = 2;
            this.chkIncludeComments.Text = "Include Comments";
            this.chkIncludeComments.UseVisualStyleBackColor = true;
            // 
            // btnGenerateClass
            // 
            this.btnGenerateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGenerateClass.Location = new System.Drawing.Point(38, 102);
            this.btnGenerateClass.Name = "btnGenerateClass";
            this.btnGenerateClass.Size = new System.Drawing.Size(140, 23);
            this.btnGenerateClass.TabIndex = 3;
            this.btnGenerateClass.Text = "Generate My Class";
            this.btnGenerateClass.UseVisualStyleBackColor = true;
            this.btnGenerateClass.Click += new System.EventHandler(this.btnGenerateClass_Click);
            // 
            // chkRuleComments
            // 
            this.chkRuleComments.AutoSize = true;
            this.chkRuleComments.Checked = true;
            this.chkRuleComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRuleComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chkRuleComments.Location = new System.Drawing.Point(12, 64);
            this.chkRuleComments.Name = "chkRuleComments";
            this.chkRuleComments.Size = new System.Drawing.Size(138, 17);
            this.chkRuleComments.TabIndex = 4;
            this.chkRuleComments.Text = "Include Rule Comments";
            this.chkRuleComments.UseVisualStyleBackColor = true;
            // 
            // chkXMLComments
            // 
            this.chkXMLComments.AutoSize = true;
            this.chkXMLComments.Checked = true;
            this.chkXMLComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXMLComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chkXMLComments.Location = new System.Drawing.Point(12, 80);
            this.chkXMLComments.Name = "chkXMLComments";
            this.chkXMLComments.Size = new System.Drawing.Size(213, 17);
            this.chkXMLComments.TabIndex = 5;
            this.chkXMLComments.Text = "Include XML Documentation Comments";
            this.chkXMLComments.UseVisualStyleBackColor = true;
            // 
            // GenerateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(231, 143);
            this.Controls.Add(this.chkXMLComments);
            this.Controls.Add(this.chkRuleComments);
            this.Controls.Add(this.btnGenerateClass);
            this.Controls.Add(this.chkIncludeComments);
            this.Controls.Add(this.ddlLanguage);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateClassForm";
            this.Text = "Generate Class";
            this.Load += new System.EventHandler(this.GenerateClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlLanguage;
        private System.Windows.Forms.CheckBox chkIncludeComments;
        private System.Windows.Forms.Button btnGenerateClass;
        private System.Windows.Forms.CheckBox chkRuleComments;
        private System.Windows.Forms.CheckBox chkXMLComments;
    }
}