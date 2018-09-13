using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using ScintillaNET;

namespace TokenIcer
{
    public partial class MainForm : Form
    {
        #region Fields
        private Processor _processor;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());

            txtInputGrammar.Styles[Style.Default].BackColor = Color.FromArgb(100, 100, 100);
            txtInputGrammar.Styles[Style.Default].ForeColor = Color.FromArgb(225, 225, 225);
            txtInputGrammar.Styles[Style.Default].Font = "Consolas";
            txtInputGrammar.Styles[Style.Default].Size = 12;
            txtInputGrammar.Margins.Capacity = 0;
            txtInputGrammar.StyleClearAll();

            txtInputTest.Styles[Style.Default].BackColor = Color.FromArgb(100, 100, 100);
            txtInputTest.Styles[Style.Default].ForeColor = Color.FromArgb(225, 225, 225);
            txtInputTest.Styles[Style.Default].Font = "Consolas";
            txtInputTest.Styles[Style.Default].Size = 12;
            txtInputTest.Margins.Capacity = 0;
            txtInputTest.StyleClearAll();

            txtOutput.Styles[Style.Default].BackColor = Color.FromArgb(100, 100, 100);
            txtOutput.Styles[Style.Default].ForeColor = Color.FromArgb(225, 225, 225);
            txtOutput.Styles[Style.Default].Font = "Consolas";
            txtOutput.Styles[Style.Default].Size = 12;
            txtOutput.Margins.Capacity = 0;
            txtOutput.StyleClearAll();
        }
        #endregion

        #region Private Methods
        private void UpdateTree(Token token)
        {
            var valueNode = new TreeNode("\"" + token.TokenValue + "\"");
            var arrayNode = new[] { valueNode };
            var keyNode = new TreeNode(token.TokenName, arrayNode);

            tvOutput.Nodes.Add(keyNode);
        }

        private void ProcessTestInput()
        {
            var token = _processor.GetToken();

            while (token != null)
            {
                txtOutput.ReadOnly = false;
                txtOutput.Text = txtOutput.Text + @"{" + token.TokenName + @"} ";
                txtOutput.ReadOnly = true;
                UpdateTree(token);

                token = _processor.GetToken();
            }
        }

        private string GetExampleCode(string name)
        {
            try
            {
                StreamReader textStreamReader;
                Assembly assembly = Assembly.GetExecutingAssembly();

                try
                {
                    textStreamReader =
                        new StreamReader(assembly.GetManifestResourceStream(name));
                }
                catch
                {
                    return "";
                }

                string retval = textStreamReader.ReadToEnd();
                textStreamReader.Close();
                return retval;
            }
            catch
            {
                return "";
            }
        }

        private void SaveFile(string filename, TokenIcerModel model)
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(model));
        }
        #endregion

        #region Event Handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            _processor = new Processor();
        }

        private void BtnTestGrammar_Click(object sender, EventArgs e)
        {
            _processor.InputString = txtInputTest.Text;
            _processor.IgnoreSpaces = chkIgnoreSpaces.Checked;

            txtOutput.ReadOnly = false;
            txtOutput.Text = string.Empty;
            txtOutput.ReadOnly = true;
            tvOutput.Nodes.Clear();
            foreach (var line in txtInputGrammar.Lines)
            {
                if ((line.Text.Trim().Equals(string.Empty)) || (line.Text.Trim().StartsWith("#")))
                    continue;
                string regex = string.Empty;
                char prevChar = '\0';
                char prevPrevChar = '\0';
                int quoteNum = 0;

                int ndx = 0;

                foreach (char c in line.Text)
                {
                    if (c == '\"')
                    {
                        quoteNum++;

                        if (quoteNum > 1 && prevChar == '\\' && prevPrevChar == '\\')
                        {
                            regex += c;
                            ndx++;
                            break;
                        }
                        if (quoteNum > 1 && prevChar != '\\')
                        {
                            regex += c;
                            ndx++;
                            break;
                        }
                    }

                    regex += c;
                    ndx++;
                    prevPrevChar = prevChar;
                    prevChar = c;
                }
                string ident = line.Text.Remove(0, ndx).Trim();

                int ndxComment = ident.Length - 1;

                while (ndxComment > 0)
                {
                    if (ident[ndxComment] == '#')
                        break;
                    ndxComment--;
                }
                if (ndxComment > 0)
                {
                    ident = ident.Substring(0, ndxComment);
                    ident = ident.Trim();
                }

                regex = regex.Substring(1, regex.Length - 1);
                regex = regex.Substring(0, regex.Length - 1);
                regex = regex.Replace("\\\"", "\"");

                if (regex.Equals(string.Empty))
                    continue;

                string retval = _processor.AddRegExToken(regex, ident);
                if (retval != string.Empty)
                {
                    MessageBox.Show(retval, "Error!");
                    return;
                }
            }

            ProcessTestInput();
            _processor.ResetProcessor();
        }

        private void BtnGenerateClass_Click(object sender, EventArgs e)
        {
            var form = new GenerateClassForm {IgnoreSpaces = chkIgnoreSpaces.Checked};

            foreach (var line in txtInputGrammar.Lines)
            {
                if ((line.Text.Trim().Equals(string.Empty)) || (line.Text.Trim().StartsWith("#")))
                    continue;

                var regex = string.Empty;
                var prevChar = '\0';
                var prevPrevChar = '\0';
                var quoteNum = 0;

                var ndx = 0;

                foreach (var c in line.Text)
                {
                    if (c == '\"')
                    {
                        quoteNum++;
                        if (quoteNum > 1 && prevChar == '\\' && prevPrevChar == '\\')
                        {
                            regex += c;
                            ndx++;
                            break;
                        }
                        if (quoteNum > 1 && prevChar != '\\')
                        {
                            regex += c;
                            ndx++;
                            break;
                        }
                    }

                    regex += c;
                    ndx++;
                    prevPrevChar = prevChar;
                    prevChar = c;
                }
                string ident = line.Text.Remove(0, ndx).Trim();
                string comment = string.Empty;

                int ndxComment = ident.Length - 1;
                while (ndxComment > 0)
                {
                    if (ident[ndxComment] == '#')
                        break;
                    ndxComment--;
                }
                if (ndxComment > 0)
                {
                    comment = ident.Substring(ndxComment, ident.Length - ndxComment);
                    ident = ident.Substring(0, ndxComment);
                    ident = ident.Trim();
                }
                regex = regex.Substring(1, regex.Length - 1);
                regex = regex.Substring(0, regex.Length - 1);
                regex = regex.Replace("\\\"", "\"");

                if (regex.Equals(string.Empty))
                    continue;
                form.AddRule(ident, regex);
                if (!(comment.Equals(string.Empty)))
                    form.AddComment(ident, comment);
            }

            form.ShowDialog();
        }

        private void SimpleBASICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetExampleCode("TokenIcer.Examples.SimpleBASIC.txt");
            string grammar = code.Split('~')[0];
            string test = code.Split('~')[1];
            bool ignoreSpaces = bool.Parse(code.Split('~')[2]);

            txtInputGrammar.Text = grammar;
            txtInputTest.Text = test;
            chkIgnoreSpaces.Checked = ignoreSpaces;
        }

        private void simpleCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetExampleCode("TokenIcer.Examples.SimpleC.txt");
            string grammar = code.Split('~')[0];
            string test = code.Split('~')[1];
            bool ignoreSpaces = bool.Parse(code.Split('~')[2]);

            txtInputGrammar.Text = grammar;
            txtInputTest.Text = test;
            chkIgnoreSpaces.Checked = ignoreSpaces;
        }

        private void SaveInputGrammarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var model = new TokenIcerModel
            {
                InputGrammar = txtInputGrammar.Text,
                InputTest = txtInputTest.Text,
                TokenicerVersion = $"{fvi.FileVersion}"
            };

            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            SaveFile(saveFileDialog1.FileName, model);
        }

        private void LoadGrammarAndTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            string json = File.ReadAllText(openFileDialog1.FileName);
            TokenIcerModel model = JsonConvert.DeserializeObject<TokenIcerModel>(json);

            txtInputGrammar.Text = model.InputGrammar;
            txtInputTest.Text = model.InputTest;
            chkIgnoreSpaces.Checked = model.IgnoreSpaces;
        }
        #endregion
    }
}
