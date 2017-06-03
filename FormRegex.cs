using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudingRegex
{
    public partial class FormRegex : Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

        // Поиск подстроки
        private void buttonMatch_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Clear();
                foreach (var line in richTextBoxInput.Lines)
                {
                    if (Regex.IsMatch(line, textBoxFind.Text))
                        richTextBoxResult.Text += @"Найдено в позиции " + Regex.Match(line, textBoxFind.Text).Index + Environment.NewLine;
                    else
                        richTextBoxResult.Text += @"Не найдено" + Environment.NewLine;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Ошибка поиска!" + Environment.NewLine + exception.Message);
            }
        }

        // Замена
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Clear();
                foreach (var line in richTextBoxInput.Lines)
                {
                    richTextBoxResult.Text += Regex.IsMatch(line, textBoxFind.Text) 
                        ? Regex.Replace(line, textBoxFind.Text, textBoxReplace.Text, RegexOptions.IgnoreCase) + Environment.NewLine
                        : line + Environment.NewLine;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Ошибка замены!" + Environment.NewLine + exception.Message);
            }
        }

        // Разбор csv-файла
        private void buttonWord_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxInput.Clear();
                richTextBoxResult.Clear();

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
                    using (var streamReader = new StreamReader(fileName, Encoding.Default))
                    {
                        richTextBoxInput.Text = streamReader.ReadToEnd();
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
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Ошибка разбора csv-файла!" + Environment.NewLine + exception.Message);
            }
        }
    }
}
