using System;
using System.Collections.Generic;
using System.Text;
using Ark.Entities.DTO;

namespace Ark.Entities.BO
{
   public class BusinessPackageSalesBO
    {
        public TblBusinessPackage BusinessPackage { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
