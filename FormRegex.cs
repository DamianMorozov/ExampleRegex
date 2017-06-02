using System;
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
                if (Regex.IsMatch(textBoxInput.Text, textBoxFind.Text))
                    textBoxResultMatch.Text = @"Найдено в позиции " + Regex.Match(textBoxInput.Text, textBoxFind.Text).Index;
                else
                    textBoxResultMatch.Text = @"Не найдено";
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
                if (Regex.IsMatch(textBoxInput.Text, textBoxFind.Text))
                    textBoxResultReplace.Text = Regex.Replace(textBoxInput.Text, textBoxFind.Text, textBoxReplace.Text, RegexOptions.IgnoreCase);
                else
                    textBoxResultReplace.Text = textBoxInput.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Ошибка поиска!" + Environment.NewLine + exception.Message);
            }
        }
    }
}
