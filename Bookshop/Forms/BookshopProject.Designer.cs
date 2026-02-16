namespace Bookshop
{
    partial class BookshopProject
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxCard = new System.Windows.Forms.GroupBox();
            this.checkBoxHasDicount = new System.Windows.Forms.CheckBox();
            this.labelTitleText = new System.Windows.Forms.Label();
            this.labelGenreText = new System.Windows.Forms.Label();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.labelBookId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.BookshopMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.groupBoxCard.SuspendLayout();
            this.BookshopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToOrderColumns = true;
            this.MainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGrid.AutoGenerateColumns = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.AuthorId,
            this.GenreId});
            this.MainGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainGrid.DataSource = this.bookBindingSource;
            this.MainGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainGrid.Location = new System.Drawing.Point(0, 24);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(573, 475);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            this.MainGrid.SelectionChanged += new System.EventHandler(this.MainGrid_SelectionChanged);
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxCard.Controls.Add(this.checkBoxHasDicount);
            this.groupBoxCard.Controls.Add(this.labelTitleText);
            this.groupBoxCard.Controls.Add(this.labelGenreText);
            this.groupBoxCard.Controls.Add(this.labelBookAuthor);
            this.groupBoxCard.Controls.Add(this.labelBookId);
            this.groupBoxCard.Controls.Add(this.textBoxId);
            this.groupBoxCard.Controls.Add(this.textBoxTitle);
            this.groupBoxCard.Controls.Add(this.textBoxGenre);
            this.groupBoxCard.Controls.Add(this.textBoxAuthor);
            this.groupBoxCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCard.Location = new System.Drawing.Point(579, 24);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(402, 487);
            this.groupBoxCard.TabIndex = 1;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Card";
            this.groupBoxCard.Enter += new System.EventHandler(this.groupBoxCard_Enter);
            // 
            // checkBoxHasDicount
            // 
            this.checkBoxHasDicount.AutoSize = true;
            this.checkBoxHasDicount.Location = new System.Drawing.Point(27, 293);
            this.checkBoxHasDicount.Name = "checkBoxHasDicount";
            this.checkBoxHasDicount.Size = new System.Drawing.Size(91, 24);
            this.checkBoxHasDicount.TabIndex = 10;
            this.checkBoxHasDicount.Text = "Discount";
            this.checkBoxHasDicount.UseVisualStyleBackColor = true;
            // 
            // labelTitleText
            // 
            this.labelTitleText.AutoSize = true;
            this.labelTitleText.Location = new System.Drawing.Point(23, 191);
            this.labelTitleText.Name = "labelTitleText";
            this.labelTitleText.Size = new System.Drawing.Size(38, 20);
            this.labelTitleText.TabIndex = 8;
            this.labelTitleText.Text = "Title";
            // 
            // labelGenreText
            // 
            this.labelGenreText.AutoSize = true;
            this.labelGenreText.Location = new System.Drawing.Point(23, 138);
            this.labelGenreText.Name = "labelGenreText";
            this.labelGenreText.Size = new System.Drawing.Size(54, 20);
            this.labelGenreText.TabIndex = 7;
            this.labelGenreText.Text = "Genre";
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Location = new System.Drawing.Point(23, 85);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(57, 20);
            this.labelBookAuthor.TabIndex = 6;
            this.labelBookAuthor.Text = "Author";
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Location = new System.Drawing.Point(23, 30);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(67, 20);
            this.labelBookId.TabIndex = 5;
            this.labelBookId.Text = "Book ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(27, 53);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(215, 26);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(27, 214);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(215, 26);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(27, 161);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(215, 26);
            this.textBoxGenre.TabIndex = 1;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(27, 108);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(215, 26);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // BookshopMenu
            // 
            this.BookshopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemEdit,
            this.MenuItemDelete});
            this.BookshopMenu.Location = new System.Drawing.Point(0, 0);
            this.BookshopMenu.Name = "BookshopMenu";
            this.BookshopMenu.Size = new System.Drawing.Size(981, 24);
            this.BookshopMenu.TabIndex = 2;
            this.BookshopMenu.Text = "menuStrip1";
            this.BookshopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BookshopMenu_ItemClicked);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(71, 20);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(99, 20);
            this.MenuItemEdit.Text = "Редактировать";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(63, 20);
            this.MenuItemDelete.Text = "Удалить";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // AuthorId
            // 
            this.AuthorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorId.DataPropertyName = "AuthorName";
            this.AuthorId.HeaderText = "Author";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ReadOnly = true;
            // 
            // GenreId
            // 
            this.GenreId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GenreId.DataPropertyName = "GenreName";
            this.GenreId.HeaderText = "Genre";
            this.GenreId.Name = "GenreId";
            this.GenreId.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Bookshop.Classes.Book);
            // 
            // BookshopProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 511);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.BookshopMenu);
            this.MainMenuStrip = this.BookshopMenu;
            this.Name = "BookshopProject";
            this.Text = "Bookshop";
            this.Load += new System.EventHandler(this.Bookshop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxCard.PerformLayout();
            this.BookshopMenu.ResumeLayout(false);
            this.BookshopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasDiscountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreId;
        private System.Windows.Forms.GroupBox groupBoxCard;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelTitleText;
        private System.Windows.Forms.Label labelGenreText;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.CheckBox checkBoxHasDicount;
        private System.Windows.Forms.MenuStrip BookshopMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
    }
}

