using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IPurchaseRepository
    {
        public IQueryable<PurchaseItem> PurchaseItems { get; }

        public void SavePurchase(PurchaseItem purchase);
    }
}
