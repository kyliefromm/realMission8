using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Mission7.Controllers;

namespace Mission7.Models
{
    public class EFBuyBookRepository :IBuyBookRepository
    {
        private BookContext context;
        public EFBuyBookRepository(BookContext temp)
        {
            context = temp;
        }
        public IQueryable<BuyBook> BuyBooks => context.BuyBooks.Include(x => x.Lines).ThenInclude(x => x.Book);

        public IQueryable<BuyBook> buyBooks => throw new NotImplementedException();

        public void SaveBook(BuyBook buyBook)
        {
            context.AttachRange(buyBook.Lines.Select(x => x.Book));

            if (buyBook.BuyBookId == 0)
            {
                context.BuyBooks.Add(buyBook);
            }

            context.SaveChanges();
        }

        public void SaveBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

