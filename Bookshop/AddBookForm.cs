using Bookshop.Classes;
using System;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEditGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void libraryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Library.AddBook(textBoxEditTitle.Text, comboBoxEditAuthor.Text, comboBoxEditGenre.Text, checkBoxEditHasDiscount.Checked);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
