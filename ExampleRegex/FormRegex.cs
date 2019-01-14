using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExmampleRegex
{
    public partial class FormRegex : Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Load file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLoadFile_Click(object sender, EventArgs e)
		{
			richTextBoxInput.Clear();
			richTextBoxResult.Clear();

			try
			{
				var openFileDialog = new OpenFileDialog
				{
					InitialDirectory = Directory.GetCurrentDirectory(),
					Filter = @"txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
					FilterIndex = 2,
					RestoreDirectory = true
				};

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					var fileName = openFileDialog.FileName;
					FileStream fileStream = null;
					try
					{
						fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
						using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
						{
							richTextBoxInput.Text = streamReader.ReadToEnd();
							richTextBoxInput.Focus();
							richTextBoxInput.Select(richTextBoxInput.Text.Length, 0);
						}
					}
					finally
					{
						fileStream?.Close();
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private string GetStrMatch()
		{
			string strMatch = textBoxFind.Text;

			if (checkBoxStartWith.Checked)
				strMatch = "^" + strMatch;
			if (checkBoxEndWith.Checked)
				strMatch = strMatch + "$";

			return strMatch;
		}

		/// <summary>
		/// Search substring
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMatch_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            try
            {
				bool isFind = false;
				string strMatch = GetStrMatch();
				bool isIgnoreCase = checkBoxIgnoreCase.Checked;
				if (!string.IsNullOrEmpty(strMatch))
				{
					int lineNumber = 1;
					foreach (var line in richTextBoxInput.Lines)
					{
						if (Regex.IsMatch(line, strMatch, isIgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None))
						{
							isFind = true;
							richTextBoxResult.Text += $@"Substring is find at line: {lineNumber}, position: {Regex.Match(line, strMatch, 
								isIgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None).Index}." + Environment.NewLine;
						}
						lineNumber++;
					}
				}
				if (!isFind)
					richTextBoxResult.Text += @"Substring not find!" + Environment.NewLine;
			}
			catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
		/// Replace substring
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            try
            {
				bool isReplace = false;
				string strMatch = GetStrMatch();
				string strReplace = textBoxReplace.Text;
				bool isIgnoreCase = checkBoxIgnoreCase.Checked;
				if (!string.IsNullOrEmpty(strMatch) && !string.IsNullOrEmpty(strReplace))
				{
					foreach (var line in richTextBoxInput.Lines)
					{
						if (Regex.IsMatch(line, strMatch, isIgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None))
						{
							isReplace = true;
							richTextBoxResult.Text += Regex.Replace(line, strMatch, strReplace, 
								isIgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None) + Environment.NewLine;
						}
						else
							richTextBoxResult.Text += line + Environment.NewLine;
					}
				}
				if (!isReplace)
					richTextBoxResult.Text += @"Substring not replace!" + Environment.NewLine;
			}
			catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
		/// Parsing csv-file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonWord_Click(object sender, EventArgs e)
        {
			richTextBoxResult.Clear();
			try
			{
                const string separator = ";";
                string pattern = $"{separator}(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))";
				foreach (var line in richTextBoxInput.Lines)
                {
                    var words = Regex.Split(line, pattern);
                    foreach (var word in words)
                    {
                        var lineToPrint = word.TrimStart('"');
                        lineToPrint = lineToPrint.TrimEnd('"');
                        richTextBoxResult.Text += lineToPrint + Environment.NewLine;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
		/// Replace macro names
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonReplaceMacro_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            try
            {
                string pattern = @"%[^\s%]+%";
				bool isIgnoreCase = checkBoxIgnoreCase.Checked;
				foreach (var line in richTextBoxInput.Lines)
                {
                    var matches = Regex.Matches(line, pattern);
                    if (matches.Count>0)
                    foreach (Match match in matches)
                    {
                        if (match.Value == textBoxFind.Text)
                            richTextBoxResult.Text += Regex.Replace(line, textBoxFind.Text, textBoxReplace.Text, 
								isIgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None) + Environment.NewLine;
                    }
                    else
                        richTextBoxResult.Text += line + Environment.NewLine;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

		private void richTextBoxInput_TextChanged(object sender, EventArgs e)
		{
			if (sender is RichTextBox richTextBox)
			{
				if (richTextBox.Text.Length == 0)
				{
					buttonMatch.Enabled = buttonReplace.Enabled = buttonCsv.Enabled = buttonReplaceMacro.Enabled =
						textBoxFind.Enabled = textBoxReplace.Enabled = 
						checkBoxIgnoreCase.Enabled = checkBoxStartWith.Enabled = checkBoxEndWith.Enabled = false;
				}
				else
				{
					buttonMatch.Enabled = buttonReplace.Enabled = buttonCsv.Enabled = buttonReplaceMacro.Enabled =
						textBoxFind.Enabled = textBoxReplace.Enabled =
						checkBoxIgnoreCase.Enabled = checkBoxStartWith.Enabled = checkBoxEndWith.Enabled = true;
				}
			}
		}
	}
}
