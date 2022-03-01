using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Mission7.Controllers;

namespace Mission7.Models.ViewModels
{
    public class EFDonationRepository : IDonationRepository
    {
        private BookContext context;
        public EFDonationRepository(BookContext temp)
        {
            context = temp;
        }
        public IQueryable<BuyBook> Donations => context.BuyBooks.Include(x => x.Lines).ThenInclude(x => x.Project);

        public void SaveDonation(BuyBook buyBook)
        {
            context.AttachRange(BuyBook.Lines.Select(x => x.Project));

            if (BuyBook.BuyBookId == 0)
            {
                context.Donations.Add(donation);
            }

            context.SaveChanges();
        }
    }
}

