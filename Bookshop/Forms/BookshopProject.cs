using Bookshop.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class BookshopProject : Form
    {
        public BookshopProject()
        {
            InitializeComponent();
        }

        private void Bookshop_Load(object sender, EventArgs e)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var filesDir = Path.Combine(baseDir, "Files");

            try
            {
                Library.LoadBooks(Path.Combine(filesDir, "Books.txt"));
                Library.LoadGenres(Path.Combine(filesDir, "Genres.txt"));
                Library.LoadAuthors(Path.Combine(filesDir, "Authors.txt"));
                MainGrid.DataSource = Library.books;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count > 0)
            {
                var book = MainGrid.SelectedRows[0].DataBoundItem as Book;

                if (book is null)
                {
                    MessageBox.Show("Выберите книгу!");
                    return;
                }
                textBoxId.Text = book.Id.ToString();
                textBoxAuthor.Text = book.AuthorName.ToString();
                textBoxGenre.Text = book.GenreName.ToString();
                textBoxTitle.Text = book.Title.ToString();
                checkBoxHasDicount.Checked = book.HasDiscount;
            }
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            var result = addBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MainGrid.Refresh();
            }
        }


        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить книгу?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var book = MainGrid.SelectedRows[0].DataBoundItem as Book;

                if (book is null)
                {
                    MessageBox.Show("Книга не выбрана", "Ошибка!");
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    Library.DeleteBook(book.Id);
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу!", "Ошибка!");
            }
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите книгу!", "Ошибка!");
                return;
            }

            var book = MainGrid.SelectedRows[0].DataBoundItem as Book;
            if (book is null)
            {
                MessageBox.Show("Книга не выбрана", "Ошибка!");
                return;
            }

            AddBookForm editBook = new AddBookForm(book);
            var result = editBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                MainGrid.Refresh();
            }
        }
    }
}