using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Library
    {
        public List<Category> Categories
        {
            get; 
            set; 
        }

        public Library()
        {
            Categories = new List<Category>();
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }
    }

}
