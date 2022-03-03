using System;
using System.Linq;
using Mission7.Controllers;

namespace Mission7.Models
{

    public interface IBuyBookRepository
    {
        IQueryable<BuyBook> buyBooks { get; }

         void SaveBook(BuyBook buyBook);
            void SaveBook(Book book);
    }
}



