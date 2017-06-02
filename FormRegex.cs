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
                    textBoxResult.Text = @"Найдено в позиции " + Regex.Match(textBoxInput.Text, textBoxFind.Text).Index;
                else
                    textBoxResult.Text = @"Не найдено";
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Ошибка поиска!" + Environment.NewLine + exception.Message);
            }
        }
    }
}
