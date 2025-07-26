using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Category
    {
        public string Name
        { 
            get; 
            set; 
        }
        public List<Book> Books 
        { 
            get;
            set; 
        }
        public Category(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }

}
