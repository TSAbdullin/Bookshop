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
    }
}
