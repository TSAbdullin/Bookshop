using Bookshop.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class AddBookForm : Form
    {
        static readonly HashSet<char> restrictedChars = new HashSet<char> { ':', '/', '[', ']', '=', '-', '^', '#', '@', '.' };
        private readonly Book _editingBook;
        public AddBookForm()
        {
            InitializeComponent();
        }

        public AddBookForm(Book bookToEdit)
        {
            InitializeComponent();

            if (bookToEdit is null)
            {
                throw new ArgumentNullException("Книга не задана");
            }

            _editingBook = bookToEdit;
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            comboBoxEditGenre.DataSource = Library.GetGenres();
            comboBoxEditGenre.DisplayMember = "Name";
            comboBoxEditGenre.ValueMember = "Id";

            comboBoxEditAuthor.DataSource = Library.GetAuthors();
            comboBoxEditAuthor.DisplayMember = "Name";
            comboBoxEditAuthor.ValueMember = "Id";

            if (_editingBook != null)
            {
                textBoxEditTitle.Text = _editingBook.Title;
                comboBoxEditAuthor.SelectedValue = _editingBook.AuthorId;
                comboBoxEditGenre.SelectedValue = _editingBook.GenreId;
                checkBoxEditHasDiscount.Checked = _editingBook.HasDiscount;
            }
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
                if (_editingBook == null)
                {
                    Library.AddBook(title, authorId, genreId, checkBoxEditHasDiscount.Checked);
                }
                else
                {
                    _editingBook.Title = title;
                    _editingBook.AuthorId = authorId;
                    _editingBook.GenreId = genreId;
                    _editingBook.HasDiscount = checkBoxEditHasDiscount.Checked;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}