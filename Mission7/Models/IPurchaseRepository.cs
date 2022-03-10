﻿using System;
using System.Linq;
using Mission7.Controllers;

namespace Mission7.Models
{

    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

         void SavePurchase(Purchase purchase);
         
    }
}



