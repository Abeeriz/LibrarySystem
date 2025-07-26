using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Book
    {
        public string Title
        { 
            get; 
            set; 
        }
        public string Author 
        {
            get;
            set;
        }
        public Category Category
        { 
            get; 
            set; 
        }

        public decimal Price
        
        {
            get;
            set;
        }
        public Book(string title, string author, Category category, decimal price)
        {
            Title = title;
            Author = author;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} - Price: {Price:C}";
        }
    }

}
