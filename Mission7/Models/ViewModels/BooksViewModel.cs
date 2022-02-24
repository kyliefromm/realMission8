using System;
using System.Linq;
using WaterProject.Models;

namespace Mission7.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
