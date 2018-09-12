using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TokenIcer
{
    public partial class GenerateClassForm : Form
    {
        private readonly Dictionary<string, string> _regExRules;
        private readonly Dictionary<string, string> _ruleComments;

        public GenerateClassForm()
        {
            InitializeComponent();
            _regExRules = new Dictionary<string, string>();
            _ruleComments = new Dictionary<string, string>();
        }

        private void GenerateClassForm_Load(object sender, EventArgs e)
        {
            ddlLanguage.SelectedItem = "C#";
        }

        public void AddRule(string key, string value)
        {
            _regExRules.Add(key, value);
        }

        public void AddComment(string key, string value)
        {
            _ruleComments.Add(key, value);
        }

        private int SkipWhiteSpace(string line, int ndx)
        {
            while (ndx < line.Length)
            {
                if (line[ndx] == '\t' || line[ndx] == ' ')
                {
                    ndx++;
                    continue;
                }
                break;
            }
            return ndx;
        }

        private void btnGenerateClass_Click(object sender, EventArgs e)
        {
            string program = string.Empty;
            const string carriageReturn = "\r\n";
            int ndx = 1;
            ITokenIcerLanguage language = null;

            if (((string)ddlLanguage.SelectedItem).Equals("VB.NET"))
            {
                language = new LanguageVBNet();
            }
            if (((string)ddlLanguage.SelectedItem).Equals("C#"))
            {
                language = new LanguageCSharp();
            }
            if (((string)ddlLanguage.SelectedItem).Equals("F#"))
            {
                language = new LanguageFSharp();
            }
            if (language != null)
            {
                string skeleton = language.GetSkeletonCode();
                string commentDelimiter = language.GetCommentIdentifier();
                string commentXmlDelimiter = language.GetXmlCommentIdentifier();
                int partNum = 1;

                foreach (string line in Regex.Split(skeleton, carriageReturn))
                {
                    var ndx2 = 0;
                    var isComment = true;
                    var isXmlComment = true;

                    ndx2 = SkipWhiteSpace(line, ndx2);
                    var ndx3 = 0;
                    var ndx4 = 0;
                    var ndx5 = ndx2;

                    while (ndx4 < commentXmlDelimiter.Length && ndx2 < line.Length)
                    {
                        if (line[ndx2] == commentXmlDelimiter[ndx4])
                        {
                            ndx4++;
                            ndx2++;
                            continue;
                        }
                        isXmlComment = false;
                        break;
                    }

                    if (isXmlComment && ndx2 < line.Length)
                    {
                        if (chkXMLComments.Checked)
                        {
                            program = program + line + carriageReturn;
                            continue;
                        }
                    }

                    ndx2 = ndx5;

                    while (ndx3 < commentDelimiter.Length && ndx2 < line.Length)
                    {
                        if (line[ndx2] == commentDelimiter[ndx3])
                        {
                            ndx3++;
                            ndx2++;
                            continue;
                        }
                        isComment = false;
                        break;
                    }
                    if (isComment && ndx2 < line.Length)
                    {
                        if (chkIncludeComments.Checked)
                        {
                            program = program + line + carriageReturn;
                        }
                        continue;
                    }
                    if (line.Contains(@"\$$$\"))
                    {
                        if (partNum == 1)
                        {
                            string replacement = "";
                            int indentWidth = language.GetIndentWidth(1);
                            foreach (KeyValuePair<string, string> pair in _regExRules)
                            {
                                if (ndx != _regExRules.Count)
                                {
                                    replacement = replacement + MakeTabs(indentWidth) +
                                                  language.CreateEnum(pair.Key, ndx, false);
                                    if (chkRuleComments.Checked)
                                    {
                                        string cmt = GetRuleComment(pair.Key, language.GetCommentIdentifier());
                                        replacement = replacement + cmt + carriageReturn;
                                    }
                                    else
                                    {
                                        replacement = replacement + carriageReturn;
                                    }
                                }
                                else
                                {
                                    replacement = replacement + MakeTabs(indentWidth) +
                                                  language.CreateEnum(pair.Key, ndx, true);
                                    if (chkRuleComments.Checked)
                                    {
                                        string cmt = GetRuleComment(pair.Key, language.GetCommentIdentifier());
                                        replacement = replacement + cmt + carriageReturn;
                                    }
                                    else
                                    {
                                        replacement = replacement + carriageReturn;
                                    }
                                }
                                ndx++;
                            }
                            program = program + line.Replace(@"\$$$\", replacement);
                            partNum++;
                        }
                        else if (partNum == 2)
                        {
                            string replacement = "";
                            int indentWidth = language.GetIndentWidth(2);
                            foreach (KeyValuePair<string, string> pair in _regExRules)
                            {
                                replacement = replacement + MakeTabs(indentWidth) + language.AddToken(pair.Key, pair.Value) + carriageReturn;
                            }
                            program = program + line.Replace(@"\$$$\", replacement);
                            partNum++;
                        }
                    }
                    else program = program + line + carriageReturn;
                }
            }

            var form = new OutputForm { Output = program };
            form.ShowDialog();
        }

        private string GetRuleComment(string key, string commentDelimiter)
        {
            foreach (KeyValuePair<string, string> k in _ruleComments)
            {
                if (k.Key.Equals(key))
                {
                    string cmt = k.Value.Trim();

                    if (cmt.StartsWith("#"))
                    {
                        cmt = cmt.Remove(0, 1);
                        cmt = " " + commentDelimiter + " " + cmt;
                    }
                    else cmt = string.Empty;
                    return cmt;
                }
            }
            return string.Empty;
        }

        private string MakeTabs(int number)
        {
            string tab = string.Empty;
            int num = number * 4;
            int ndx = 0;

            while (ndx < num)
            {
                tab = tab + ' ';
                ndx++;
            }

            return tab;
        }
    }
}
