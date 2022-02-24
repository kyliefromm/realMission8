using System;
using System.Linq;
using Mission7.Models;
using Mission7.Models.ViewModels;

namespace WaterProject.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookContext context { get; set; }

        public EFBookRepository(BookContext temp)
        {
            context = temp;
        }



        public IQueryable<Book> Books => context.Books;
    }
}
