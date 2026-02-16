namespace Bookshop
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEditTitle = new System.Windows.Forms.TextBox();
            this.labelEditTitle = new System.Windows.Forms.Label();
            this.labelEditGenre = new System.Windows.Forms.Label();
            this.labelEditAuthor = new System.Windows.Forms.Label();
            this.labelEditBook = new System.Windows.Forms.Label();
            this.comboBoxEditGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxEditAuthor = new System.Windows.Forms.ComboBox();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonCancelChanges = new System.Windows.Forms.Button();
            this.checkBoxEditHasDiscount = new System.Windows.Forms.CheckBox();
            this.panelWithButtons = new System.Windows.Forms.Panel();
            this.panelWithButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEditTitle
            // 
            this.textBoxEditTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditTitle.Location = new System.Drawing.Point(280, 121);
            this.textBoxEditTitle.Multiline = true;
            this.textBoxEditTitle.Name = "textBoxEditTitle";
            this.textBoxEditTitle.Size = new System.Drawing.Size(260, 28);
            this.textBoxEditTitle.TabIndex = 0;
            this.textBoxEditTitle.TextChanged += new System.EventHandler(this.textBoxEditTitle_TextChanged);
            // 
            // labelEditTitle
            // 
            this.labelEditTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditTitle.AutoSize = true;
            this.labelEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditTitle.Location = new System.Drawing.Point(208, 121);
            this.labelEditTitle.Name = "labelEditTitle";
            this.labelEditTitle.Size = new System.Drawing.Size(38, 20);
            this.labelEditTitle.TabIndex = 1;
            this.labelEditTitle.Text = "Title";
            // 
            // labelEditGenre
            // 
            this.labelEditGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditGenre.AutoSize = true;
            this.labelEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditGenre.Location = new System.Drawing.Point(208, 269);
            this.labelEditGenre.Name = "labelEditGenre";
            this.labelEditGenre.Size = new System.Drawing.Size(54, 20);
            this.labelEditGenre.TabIndex = 3;
            this.labelEditGenre.Text = "Genre";
            // 
            // labelEditAuthor
            // 
            this.labelEditAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditAuthor.AutoSize = true;
            this.labelEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditAuthor.Location = new System.Drawing.Point(208, 195);
            this.labelEditAuthor.Name = "labelEditAuthor";
            this.labelEditAuthor.Size = new System.Drawing.Size(57, 20);
            this.labelEditAuthor.TabIndex = 5;
            this.labelEditAuthor.Text = "Author";
            // 
            // labelEditBook
            // 
            this.labelEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditBook.Location = new System.Drawing.Point(289, 35);
            this.labelEditBook.Name = "labelEditBook";
            this.labelEditBook.Size = new System.Drawing.Size(251, 29);
            this.labelEditBook.TabIndex = 8;
            this.labelEditBook.Text = "Workshop Panel";
            this.labelEditBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxEditGenre
            // 
            this.comboBoxEditGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditGenre.FormattingEnabled = true;
            this.comboBoxEditGenre.Location = new System.Drawing.Point(280, 261);
            this.comboBoxEditGenre.Name = "comboBoxEditGenre";
            this.comboBoxEditGenre.Size = new System.Drawing.Size(260, 28);
            this.comboBoxEditGenre.TabIndex = 9;
            this.comboBoxEditGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditGenre_SelectedIndexChanged);
            // 
            // comboBoxEditAuthor
            // 
            this.comboBoxEditAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditAuthor.FormattingEnabled = true;
            this.comboBoxEditAuthor.Location = new System.Drawing.Point(280, 192);
            this.comboBoxEditAuthor.Name = "comboBoxEditAuthor";
            this.comboBoxEditAuthor.Size = new System.Drawing.Size(260, 28);
            this.comboBoxEditAuthor.TabIndex = 10;
            this.comboBoxEditAuthor.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditAuthor_SelectedIndexChanged);
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.BackColor = System.Drawing.Color.Lime;
            this.buttonAcceptChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAcceptChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcceptChanges.Location = new System.Drawing.Point(501, 0);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(214, 48);
            this.buttonAcceptChanges.TabIndex = 11;
            this.buttonAcceptChanges.Text = "Accept";
            this.buttonAcceptChanges.UseVisualStyleBackColor = false;
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
            // 
            // buttonCancelChanges
            // 
            this.buttonCancelChanges.BackColor = System.Drawing.Color.Red;
            this.buttonCancelChanges.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCancelChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelChanges.Location = new System.Drawing.Point(100, 0);
            this.buttonCancelChanges.Name = "buttonCancelChanges";
            this.buttonCancelChanges.Size = new System.Drawing.Size(214, 48);
            this.buttonCancelChanges.TabIndex = 12;
            this.buttonCancelChanges.Text = "Cancel";
            this.buttonCancelChanges.UseVisualStyleBackColor = false;
            this.buttonCancelChanges.Click += new System.EventHandler(this.buttonCancelChanges_Click);
            // 
            // checkBoxEditHasDiscount
            // 
            this.checkBoxEditHasDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEditHasDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEditHasDiscount.Location = new System.Drawing.Point(278, 323);
            this.checkBoxEditHasDiscount.Name = "checkBoxEditHasDiscount";
            this.checkBoxEditHasDiscount.Size = new System.Drawing.Size(91, 24);
            this.checkBoxEditHasDiscount.TabIndex = 13;
            this.checkBoxEditHasDiscount.Text = "Discount";
            this.checkBoxEditHasDiscount.UseVisualStyleBackColor = true;
            // 
            // panelWithButtons
            // 
            this.panelWithButtons.Controls.Add(this.buttonAcceptChanges);
            this.panelWithButtons.Controls.Add(this.buttonCancelChanges);
            this.panelWithButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWithButtons.Location = new System.Drawing.Point(0, 370);
            this.panelWithButtons.Name = "panelWithButtons";
            this.panelWithButtons.Padding = new System.Windows.Forms.Padding(100, 0, 100, 20);
            this.panelWithButtons.Size = new System.Drawing.Size(815, 68);
            this.panelWithButtons.TabIndex = 14;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(815, 438);
            this.Controls.Add(this.checkBoxEditHasDiscount);
            this.Controls.Add(this.comboBoxEditAuthor);
            this.Controls.Add(this.comboBoxEditGenre);
            this.Controls.Add(this.labelEditBook);
            this.Controls.Add(this.labelEditAuthor);
            this.Controls.Add(this.labelEditGenre);
            this.Controls.Add(this.labelEditTitle);
            this.Controls.Add(this.textBoxEditTitle);
            this.Controls.Add(this.panelWithButtons);
            this.Name = "AddBookForm";
            this.Text = "Add book";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.panelWithButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditTitle;
        private System.Windows.Forms.Label labelEditTitle;
        private System.Windows.Forms.Label labelEditGenre;
        private System.Windows.Forms.Label labelEditAuthor;
        private System.Windows.Forms.Label labelEditBook;
        private System.Windows.Forms.ComboBox comboBoxEditGenre;
        private System.Windows.Forms.ComboBox comboBoxEditAuthor;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonCancelChanges;
        private System.Windows.Forms.CheckBox checkBoxEditHasDiscount;
        private System.Windows.Forms.Panel panelWithButtons;
    }
}