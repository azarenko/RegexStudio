using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexStudio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filename.Text = openFileDialog1.FileName;
                _input.Text = File.ReadAllText(_filename.Text);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_filename.Text))
            {
                saveFileDialog1.FileName = _filename.Text;
            }

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, _output.Text);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var name in Enum.GetNames(typeof(RegexOptions)))
            {
                _regExGlobalOptions.Items.Add(name);
            }
        }

        private RegexOptions GetReOptions()
        {
            RegexOptions option = RegexOptions.None;

            foreach (var name in _regExGlobalOptions.CheckedItems)
            {
                RegexOptions _option = (RegexOptions)Enum.Parse(typeof(RegexOptions), (string)name);
                option |= _option;
            }

            return option;
        }

        private void _extracktHighlight_Click(object sender, EventArgs e)
        {
            Regex re;
            try
            {
                re = new Regex(_extractPattern.Text, GetReOptions());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }

            MatchCollection mc = re.Matches(_input.Text);

            if (mc.Count > 0)
            {
                HighLightInput(_input, mc);
            }
        }

        private void HighLightInput(RichTextBox rb, MatchCollection mc)
        {
            rb.SelectAll();
            rb.SelectionColor = Color.Black;
            rb.SelectionFont = new Font(rb.SelectionFont, FontStyle.Regular);
            rb.DeselectAll();

            foreach (Match m in mc)
            {
                rb.Select(m.Index, m.Length);
                rb.SelectionColor = Color.Red;
                rb.SelectionFont = new Font(rb.SelectionFont, FontStyle.Bold);
            }

            rb.DeselectAll();
        }

        private void _extractExecute_Click(object sender, EventArgs e)
        {
            switch (tabControl2.SelectedIndex)
            {
                case 0:
                    try
                    {
                        _output.Text = ExtractFunc(_input.Text);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        DirectoryExtract(_dirPath.Text);
                        MessageBox.Show("Done!");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    break;
            }
            
        }

        private void DirectoryExtract(string Path)
        {
            foreach (var subfolder in Directory.GetDirectories(Path))
            {
                DirectoryExtract(subfolder);
            }
            foreach (var filePath in Directory.GetFiles(Path, _fileFilter.Text))
            {
                _dirResult.Text += ExtractFunc(File.ReadAllText(filePath));
            }
        }

        private void _replaceHighlight_Click(object sender, EventArgs e)
        {
            Regex re;
            try
            {
                re = new Regex(_replacePattern.Text, GetReOptions());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }

            MatchCollection mc = re.Matches(_input.Text);

            if (mc.Count > 0)
            {
                HighLightInput(_input, mc);
            }
        }

        private void _replaceExecute_Click(object sender, EventArgs e)
        {
            switch (tabControl2.SelectedIndex)
            {
                case 0:
                    try
                    {
                        _output.Text = ReplaceFunc(_input.Text);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }

                    break;
                case 1:
                    try
                    {
                        DirectoryReplace(_dirPath.Text);
                        MessageBox.Show("Done!");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }

                    break;
            }
        }

        private void DirectoryReplace(string Path)
        {
            foreach (var subfolder in Directory.GetDirectories(Path))
            {
                DirectoryExtract(subfolder);
            }
            foreach (var filePath in Directory.GetFiles(Path, _fileFilter.Text))
            {
                _dirResult.Text += ReplaceFunc(File.ReadAllText(filePath));
            }
        }

        private void _selDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _dirPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private string ExtractFunc(string input)
        {
            Regex re = new Regex(_extractPattern.Text, GetReOptions());

            MatchCollection mc = re.Matches(input);

            if (mc.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (Match m in mc)
                {
                    List<string> groupValues = new List<string>();

                    groupValues.Add(m.Value);

                    foreach (Group g in m.Groups)
                    {
                        groupValues.Add(g.Value);
                    }

                    sb.Append(string.Format(_extractFormatter.Text, groupValues.ToArray()));
                }

                return sb.ToString();
            }
            else
                return string.Empty;
        }

        private string ReplaceFunc(string input)
        {
            Regex re = new Regex(_replacePattern.Text, GetReOptions());
            return re.Replace(input, _replaceFormatter.Text);
        }
    }
}
