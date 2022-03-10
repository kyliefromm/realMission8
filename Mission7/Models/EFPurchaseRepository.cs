using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Mission7.Controllers;

namespace Mission7.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookContext context;
        public EFPurchaseRepository(BookContext temp)
        {
            context = temp;
        }
        public IQueryable<Purchase>Purchases  => context.Purchases.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SaveBook(Purchase purchase)
        {
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseId == 0)
            {
                context.Purchases.Add(purchase);
            }

            context.SaveChanges();
        }

        public void SaveBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void SavePurchase(Purchase purchase)
        {
            throw new NotImplementedException();
        }
    }
}

