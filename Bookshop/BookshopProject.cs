using Bookshop.Classes;
using System;
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
            try
            {
                Library.LoadBooks("C:\\Users\\Timur\\source\\repos\\Bookshop\\Bookshop\\Files\\Books.txt"); // временная затычка для отладки
                Library.LoadGenres("C:\\Users\\Timur\\source\\repos\\Bookshop\\Bookshop\\Files\\Genres.txt"); // очередная затычка
                Library.LoadAuthors("C:\\Users\\Timur\\source\\repos\\Bookshop\\Bookshop\\Files\\Authors.txt"); // еще одна затычка
                MainGrid.DataSource = Library.books;
                MainGrid.Refresh();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count > 0)
            {
                var book = MainGrid.SelectedRows[0].DataBoundItem as Book;

                textBoxId.Text = book.Id.ToString();
                textBoxAuthor.Text = book.AuthorName.ToString();
                textBoxGenre.Text = book.GenreName.ToString();
                textBoxTitle.Text = book.Title.ToString();
                checkBoxHasDicount.Checked = book.HasDiscount;
            }
        }

        private void groupBoxCard_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxHasDiscount_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
