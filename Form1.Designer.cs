namespace LibrarySystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            categoryComboBox = new ComboBox();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            priceTextBox = new TextBox();
            addBookButton = new Button();
            deleteBookButton = new Button();
            booksListBox = new ListBox();
            newPriceTextBox = new TextBox();
            editPriceButton = new Button();
            SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 12);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(247, 28);
            categoryComboBox.TabIndex = 0;
          
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 46);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(247, 27);
            titleTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(12, 73);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(247, 27);
            authorTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 106);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(247, 27);
            priceTextBox.TabIndex = 3;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(12, 139);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(247, 33);
            addBookButton.TabIndex = 4;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // deleteBookButton
            // 
            deleteBookButton.Location = new Point(12, 178);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(247, 33);
            deleteBookButton.TabIndex = 5;
            deleteBookButton.Text = "Delete Book";
            deleteBookButton.UseVisualStyleBackColor = true;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // booksListBox
            // 
            booksListBox.FormattingEnabled = true;
            booksListBox.Location = new Point(12, 217);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(247, 104);
            booksListBox.TabIndex = 6;
            // 
            // newPriceTextBox
            // 
            newPriceTextBox.Location = new Point(12, 327);
            newPriceTextBox.Name = "newPriceTextBox";
            newPriceTextBox.Size = new Size(247, 27);
            newPriceTextBox.TabIndex = 7;
            // 
            // editPriceButton
            // 
            editPriceButton.Location = new Point(12, 360);
            editPriceButton.Name = "editPriceButton";
            editPriceButton.Size = new Size(247, 36);
            editPriceButton.TabIndex = 8;
            editPriceButton.Text = "Edit Price";
            editPriceButton.UseVisualStyleBackColor = true;
            editPriceButton.Click += editPriceButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(663, 425);
            Controls.Add(editPriceButton);
            Controls.Add(newPriceTextBox);
            Controls.Add(booksListBox);
            Controls.Add(deleteBookButton);
            Controls.Add(addBookButton);
            Controls.Add(priceTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(categoryComboBox);
            Name = "Form1";
            Text = "Library System";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private System.Windows.Forms.Button editPriceButton;
    }
}
