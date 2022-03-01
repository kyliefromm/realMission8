using System;
using System.Linq;

namespace Mission7.Models
{

    public class IDonationRepository
    {
        IQueryable<Book> Books { get; }

        void SaveBook(Book book);
    }
}

