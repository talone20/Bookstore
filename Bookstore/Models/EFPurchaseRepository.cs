using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookstoreDatabaseContext context;
        public EFPurchaseRepository (BookstoreDatabaseContext temp)
        {
            context = temp;
        }
        public IQueryable<PurchaseItem> PurchaseItems => context.PurchaseItems.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePurchase(PurchaseItem purchase)
        {
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseItemId == 0)
            {
                context.PurchaseItems.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}
