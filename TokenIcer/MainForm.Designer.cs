namespace TokenIcer
{
   partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInputGrammarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGrammarAndTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleBASICToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInputGrammar = new ScintillaNET.Scintilla();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputTest = new ScintillaNET.Scintilla();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new ScintillaNET.Scintilla();
            this.label4 = new System.Windows.Forms.Label();
            this.tvOutput = new System.Windows.Forms.TreeView();
            this.btnTestGrammar = new System.Windows.Forms.Button();
            this.btnGenerateClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassNamePrefix = new System.Windows.Forms.TextBox();
            this.chkIgnoreSpaces = new TokenIcer.TokenIcerCheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.examplesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInputGrammarToolStripMenuItem,
            this.loadGrammarAndTestToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveInputGrammarToolStripMenuItem
            // 
            this.saveInputGrammarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.saveInputGrammarToolStripMenuItem.Name = "saveInputGrammarToolStripMenuItem";
            this.saveInputGrammarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveInputGrammarToolStripMenuItem.Text = "Save Grammar and Test...";
            this.saveInputGrammarToolStripMenuItem.Click += new System.EventHandler(this.SaveInputGrammarToolStripMenuItem_Click);
            // 
            // loadGrammarAndTestToolStripMenuItem
            // 
            this.loadGrammarAndTestToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.loadGrammarAndTestToolStripMenuItem.Name = "loadGrammarAndTestToolStripMenuItem";
            this.loadGrammarAndTestToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.loadGrammarAndTestToolStripMenuItem.Text = "Load Grammar and Test...";
            this.loadGrammarAndTestToolStripMenuItem.Click += new System.EventHandler(this.LoadGrammarAndTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem.Text = "E&xit...";
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleBASICToolStripMenuItem,
            this.simpleCToolStripMenuItem});
            this.examplesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.examplesToolStripMenuItem.Text = "&Examples";
            // 
            // simpleBASICToolStripMenuItem
            // 
            this.simpleBASICToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.simpleBASICToolStripMenuItem.Name = "simpleBASICToolStripMenuItem";
            this.simpleBASICToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.simpleBASICToolStripMenuItem.Text = "Simple &BASIC";
            this.simpleBASICToolStripMenuItem.Click += new System.EventHandler(this.SimpleBASICToolStripMenuItem_Click);
            // 
            // simpleCToolStripMenuItem
            // 
            this.simpleCToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.simpleCToolStripMenuItem.Name = "simpleCToolStripMenuItem";
            this.simpleCToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.simpleCToolStripMenuItem.Text = "Simple C";
            this.simpleCToolStripMenuItem.Click += new System.EventHandler(this.simpleCToolStripMenuItem_Click);
            // 
            // txtInputGrammar
            // 
            this.txtInputGrammar.CaretForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtInputGrammar.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.txtInputGrammar.Location = new System.Drawing.Point(15, 114);
            this.txtInputGrammar.Name = "txtInputGrammar";
            this.txtInputGrammar.ScrollWidth = 1;
            this.txtInputGrammar.Size = new System.Drawing.Size(553, 250);
            this.txtInputGrammar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Grammar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(13, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Test";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInputTest
            // 
            this.txtInputTest.CaretForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtInputTest.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.txtInputTest.Location = new System.Drawing.Point(17, 428);
            this.txtInputTest.Name = "txtInputTest";
            this.txtInputTest.ScrollWidth = 1;
            this.txtInputTest.Size = new System.Drawing.Size(553, 250);
            this.txtInputTest.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(580, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.CaretForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtOutput.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.txtOutput.Location = new System.Drawing.Point(582, 114);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollWidth = 1;
            this.txtOutput.Size = new System.Drawing.Size(544, 250);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.WrapMode = ScintillaNET.WrapMode.Whitespace;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(582, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(546, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output Tree";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tvOutput
            // 
            this.tvOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tvOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tvOutput.Location = new System.Drawing.Point(584, 428);
            this.tvOutput.Name = "tvOutput";
            this.tvOutput.Size = new System.Drawing.Size(544, 250);
            this.tvOutput.TabIndex = 8;
            // 
            // btnTestGrammar
            // 
            this.btnTestGrammar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestGrammar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTestGrammar.Location = new System.Drawing.Point(230, 691);
            this.btnTestGrammar.Name = "btnTestGrammar";
            this.btnTestGrammar.Size = new System.Drawing.Size(120, 43);
            this.btnTestGrammar.TabIndex = 9;
            this.btnTestGrammar.Text = "Test Grammar";
            this.btnTestGrammar.UseVisualStyleBackColor = true;
            this.btnTestGrammar.Click += new System.EventHandler(this.BtnTestGrammar_Click);
            // 
            // btnGenerateClass
            // 
            this.btnGenerateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGenerateClass.Location = new System.Drawing.Point(974, 692);
            this.btnGenerateClass.Name = "btnGenerateClass";
            this.btnGenerateClass.Size = new System.Drawing.Size(120, 43);
            this.btnGenerateClass.TabIndex = 10;
            this.btnGenerateClass.Text = "Generate Class...";
            this.btnGenerateClass.UseVisualStyleBackColor = true;
            this.btnGenerateClass.Click += new System.EventHandler(this.BtnGenerateClass_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label5.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(0, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1142, 60);
            this.label5.TabIndex = 11;
            this.label5.Text = "TokenIcer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "tki";
            this.saveFileDialog1.Filter = "TokenIcer files|*.tki|All Files|*.*";
            this.saveFileDialog1.Title = "Save TokenIcer File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "tki";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TokenIcer files|*.tki|All Files|*.*";
            this.openFileDialog1.Title = "Open TokenIcer File";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(633, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Class Name Prefix:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtClassNamePrefix
            // 
            this.txtClassNamePrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassNamePrefix.Location = new System.Drawing.Point(777, 701);
            this.txtClassNamePrefix.Name = "txtClassNamePrefix";
            this.txtClassNamePrefix.Size = new System.Drawing.Size(187, 26);
            this.txtClassNamePrefix.TabIndex = 14;
            this.txtClassNamePrefix.Text = "Unnamed";
            // 
            // chkIgnoreSpaces
            // 
            this.chkIgnoreSpaces.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIgnoreSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIgnoreSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIgnoreSpaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chkIgnoreSpaces.Location = new System.Drawing.Point(24, 366);
            this.chkIgnoreSpaces.Name = "chkIgnoreSpaces";
            this.chkIgnoreSpaces.Size = new System.Drawing.Size(326, 26);
            this.chkIgnoreSpaces.TabIndex = 12;
            this.chkIgnoreSpaces.Text = "Ignore spaces and tabs (White Space)";
            this.chkIgnoreSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreSpaces.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1142, 757);
            this.Controls.Add(this.txtClassNamePrefix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkIgnoreSpaces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerateClass);
            this.Controls.Add(this.btnTestGrammar);
            this.Controls.Add(this.tvOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputGrammar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TokenIcer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveInputGrammarToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadGrammarAndTestToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ScintillaNET.Scintilla txtInputGrammar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ScintillaNET.Scintilla txtInputTest;
        private System.Windows.Forms.Label label3;
        private ScintillaNET.Scintilla txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvOutput;
        private System.Windows.Forms.Button btnTestGrammar;
        private System.Windows.Forms.Button btnGenerateClass;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleBASICToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleCToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TokenIcerCheckBox chkIgnoreSpaces;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassNamePrefix;
    }
}

