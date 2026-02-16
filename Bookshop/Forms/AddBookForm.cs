using Bookshop.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class AddBookForm : Form
    {
        static readonly HashSet<char> restrictedChars = new HashSet<char> { ':', '/', '[', ']', '=', '-', '^', '#', '@' };
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            comboBoxEditGenre.DataSource = Library.GetGenres();
            comboBoxEditGenre.DisplayMember = "Name";
            comboBoxEditGenre.ValueMember = "Id";

            comboBoxEditAuthor.DataSource = Library.GetAuthors();
            comboBoxEditAuthor.DisplayMember = "Name";
            comboBoxEditAuthor.ValueMember = "Id";
        }

        private void comboBoxEditGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void libraryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {

            var title = textBoxEditTitle.Text.Trim();

            if (title.Length == 0)
            {
                MessageBox.Show("Название книги не может быть пустым!");
                return;
            }

            if (comboBoxEditAuthor.SelectedValue == null || comboBoxEditGenre.SelectedValue == null)
            {
                MessageBox.Show("Выберите автора и жанр!");
                return;
            }

            foreach (var letter in title) // сложность O(N)
            {
                if (restrictedChars.Contains(letter)) // O(1), потому что множество, коллизии как будто бы невозможны ахах
                {
                    MessageBox.Show("В названии содержатся запрещённые символы!");
                    return;
                }
            }

            long authorId = (long)comboBoxEditAuthor.SelectedValue;
            long genreId = (long)comboBoxEditGenre.SelectedValue;

            try
            {
                Library.AddBook(title, authorId, genreId, checkBoxEditHasDiscount.Checked);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void textBoxEditId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxEditTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEditAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
