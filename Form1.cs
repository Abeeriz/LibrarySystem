using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Models;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();

            // Labels in lift positions 
            Label categoryLabel = new Label { Text = "Category:", Location = new Point(12, 12), AutoSize = true };
            Controls.Add(categoryLabel);

            Label titleLabel = new Label { Text = "Book Name:", Location = new Point(12, 46), AutoSize = true };
            Controls.Add(titleLabel);

            Label authorLabel = new Label { Text = "Author Name:", Location = new Point(12, 73), AutoSize = true };
            Controls.Add(authorLabel);

            Label priceLabel = new Label { Text = "Price:", Location = new Point(12, 106), AutoSize = true };
            Controls.Add(priceLabel);

            Label newPriceLabel = new Label { Text = "New Price:", Location = new Point(12, 327), AutoSize = true };
            Controls.Add(newPriceLabel);

            // ComboBox items ' drop down list'
            categoryComboBox.Items.Add("Programming");
            categoryComboBox.Items.Add("Fiction");
            categoryComboBox.Items.Add("History");
            categoryComboBox.Items.Add("Science");
            categoryComboBox.Items.Add("Other..");

            // Input right positions 
            categoryComboBox.Location = new Point(120, 12);
            titleTextBox.Location = new Point(120, 46);
            authorTextBox.Location = new Point(120, 73);
            priceTextBox.Location = new Point(120, 106);
            newPriceTextBox.Location = new Point(120, 327);
        }
        //obj sender as a click button click , EventArgs e info about the click 
        private void addBookButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text.Trim();//Trim() for the spaces 
            string author = authorTextBox.Text.Trim();
            string priceText = priceTextBox.Text.Trim();
            string categoryName = categoryComboBox.SelectedItem?.ToString(); //if not null display as a String if null 

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }
            
            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Please enter a valid price!");
                return;
            }

          //creating new obj category
            Category category = new Category(categoryName);
            Book newBook = new Book(title, author, category, price);

            books.Add(newBook);
            booksListBox.Items.Add($"{title} - {author} - {price:C} - {category.Name}");

            titleTextBox.Clear();
            authorTextBox.Clear();
            priceTextBox.Clear();
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            int index = booksListBox.SelectedIndex;
            if (index >= 0)
            {
                books.RemoveAt(index);
                booksListBox.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void editPriceButton_Click(object sender, EventArgs e)
        {
            int index = booksListBox.SelectedIndex;
            if (index >= 0)
            {
                if (decimal.TryParse(newPriceTextBox.Text, out decimal newPrice))
                {
                    books[index].Price = newPrice;

                    Book b = books[index];
                    booksListBox.Items[index] = $"{b.Title} - {b.Author} - {b.Price:C} - {b.Category.Name}";
                    newPriceTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please write a correct price.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit the price.");
            }
        }
    }
}
