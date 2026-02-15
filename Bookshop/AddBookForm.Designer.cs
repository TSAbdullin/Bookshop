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
            this.textBoxEditId = new System.Windows.Forms.TextBox();
            this.labelEditId = new System.Windows.Forms.Label();
            this.labelEditBook = new System.Windows.Forms.Label();
            this.comboBoxEditGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxEditAuthor = new System.Windows.Forms.ComboBox();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.buttonCancelChanges = new System.Windows.Forms.Button();
            this.checkBoxEditHasDiscount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxEditTitle
            // 
            this.textBoxEditTitle.Location = new System.Drawing.Point(419, 133);
            this.textBoxEditTitle.Multiline = true;
            this.textBoxEditTitle.Name = "textBoxEditTitle";
            this.textBoxEditTitle.Size = new System.Drawing.Size(245, 28);
            this.textBoxEditTitle.TabIndex = 0;
            // 
            // labelEditTitle
            // 
            this.labelEditTitle.AutoSize = true;
            this.labelEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditTitle.Location = new System.Drawing.Point(415, 108);
            this.labelEditTitle.Name = "labelEditTitle";
            this.labelEditTitle.Size = new System.Drawing.Size(38, 20);
            this.labelEditTitle.TabIndex = 1;
            this.labelEditTitle.Text = "Title";
            // 
            // labelEditGenre
            // 
            this.labelEditGenre.AutoSize = true;
            this.labelEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditGenre.Location = new System.Drawing.Point(115, 193);
            this.labelEditGenre.Name = "labelEditGenre";
            this.labelEditGenre.Size = new System.Drawing.Size(54, 20);
            this.labelEditGenre.TabIndex = 3;
            this.labelEditGenre.Text = "Genre";
            // 
            // labelEditAuthor
            // 
            this.labelEditAuthor.AutoSize = true;
            this.labelEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditAuthor.Location = new System.Drawing.Point(415, 193);
            this.labelEditAuthor.Name = "labelEditAuthor";
            this.labelEditAuthor.Size = new System.Drawing.Size(57, 20);
            this.labelEditAuthor.TabIndex = 5;
            this.labelEditAuthor.Text = "Author";
            // 
            // textBoxEditId
            // 
            this.textBoxEditId.Location = new System.Drawing.Point(119, 133);
            this.textBoxEditId.Multiline = true;
            this.textBoxEditId.Name = "textBoxEditId";
            this.textBoxEditId.ReadOnly = true;
            this.textBoxEditId.Size = new System.Drawing.Size(245, 28);
            this.textBoxEditId.TabIndex = 6;
            this.textBoxEditId.TextChanged += new System.EventHandler(this.textBoxEditId_TextChanged);
            // 
            // labelEditId
            // 
            this.labelEditId.AutoSize = true;
            this.labelEditId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditId.Location = new System.Drawing.Point(115, 108);
            this.labelEditId.Name = "labelEditId";
            this.labelEditId.Size = new System.Drawing.Size(26, 20);
            this.labelEditId.TabIndex = 7;
            this.labelEditId.Text = "ID";
            // 
            // labelEditBook
            // 
            this.labelEditBook.AutoSize = true;
            this.labelEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditBook.Location = new System.Drawing.Point(283, 25);
            this.labelEditBook.Name = "labelEditBook";
            this.labelEditBook.Size = new System.Drawing.Size(204, 29);
            this.labelEditBook.TabIndex = 8;
            this.labelEditBook.Text = "Workshop Panel";
            // 
            // comboBoxEditGenre
            // 
            this.comboBoxEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditGenre.FormattingEnabled = true;
            this.comboBoxEditGenre.Location = new System.Drawing.Point(119, 220);
            this.comboBoxEditGenre.Name = "comboBoxEditGenre";
            this.comboBoxEditGenre.Size = new System.Drawing.Size(245, 28);
            this.comboBoxEditGenre.TabIndex = 9;
            this.comboBoxEditGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditGenre_SelectedIndexChanged);
            // 
            // comboBoxEditAuthor
            // 
            this.comboBoxEditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditAuthor.FormattingEnabled = true;
            this.comboBoxEditAuthor.Location = new System.Drawing.Point(419, 220);
            this.comboBoxEditAuthor.Name = "comboBoxEditAuthor";
            this.comboBoxEditAuthor.Size = new System.Drawing.Size(245, 28);
            this.comboBoxEditAuthor.TabIndex = 10;
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.BackColor = System.Drawing.Color.Lime;
            this.buttonAcceptChanges.Location = new System.Drawing.Point(461, 332);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(157, 45);
            this.buttonAcceptChanges.TabIndex = 11;
            this.buttonAcceptChanges.Text = "Accept";
            this.buttonAcceptChanges.UseVisualStyleBackColor = false;
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
            // 
            // buttonCancelChanges
            // 
            this.buttonCancelChanges.BackColor = System.Drawing.Color.Red;
            this.buttonCancelChanges.Location = new System.Drawing.Point(159, 332);
            this.buttonCancelChanges.Name = "buttonCancelChanges";
            this.buttonCancelChanges.Size = new System.Drawing.Size(157, 45);
            this.buttonCancelChanges.TabIndex = 12;
            this.buttonCancelChanges.Text = "Cancel";
            this.buttonCancelChanges.UseVisualStyleBackColor = false;
            this.buttonCancelChanges.Click += new System.EventHandler(this.buttonCancelChanges_Click);
            // 
            // checkBoxEditHasDiscount
            // 
            this.checkBoxEditHasDiscount.AutoSize = true;
            this.checkBoxEditHasDiscount.Location = new System.Drawing.Point(348, 280);
            this.checkBoxEditHasDiscount.Name = "checkBoxEditHasDiscount";
            this.checkBoxEditHasDiscount.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEditHasDiscount.TabIndex = 13;
            this.checkBoxEditHasDiscount.Text = "Discount";
            this.checkBoxEditHasDiscount.UseVisualStyleBackColor = true;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxEditHasDiscount);
            this.Controls.Add(this.buttonCancelChanges);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.comboBoxEditAuthor);
            this.Controls.Add(this.comboBoxEditGenre);
            this.Controls.Add(this.labelEditBook);
            this.Controls.Add(this.labelEditId);
            this.Controls.Add(this.textBoxEditId);
            this.Controls.Add(this.labelEditAuthor);
            this.Controls.Add(this.labelEditGenre);
            this.Controls.Add(this.labelEditTitle);
            this.Controls.Add(this.textBoxEditTitle);
            this.Name = "AddBookForm";
            this.Text = "Add book";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditTitle;
        private System.Windows.Forms.Label labelEditTitle;
        private System.Windows.Forms.Label labelEditGenre;
        private System.Windows.Forms.Label labelEditAuthor;
        private System.Windows.Forms.TextBox textBoxEditId;
        private System.Windows.Forms.Label labelEditId;
        private System.Windows.Forms.Label labelEditBook;
        private System.Windows.Forms.ComboBox comboBoxEditGenre;
        private System.Windows.Forms.ComboBox comboBoxEditAuthor;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Button buttonCancelChanges;
        private System.Windows.Forms.CheckBox checkBoxEditHasDiscount;
    }
}