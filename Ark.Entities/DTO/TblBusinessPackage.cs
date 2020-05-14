using Ark.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Ark.Entities.DTO
{
    public partial class TblBusinessPackage
    {
        public TblBusinessPackage()
        {
            TblIncomeDistribution = new HashSet<TblIncomeDistribution>();
            TblUserBusinessPackage = new HashSet<TblUserBusinessPackage>();
        }

        public long Id { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? LastChanged { get; set; }
        public string PackageName { get; set; }
        public long? PackageTypeId { get; set; }
        public string PackageDescription { get; set; }
        public string PackageCode { get; set; }
        public decimal? ValueFrom { get; set; }
        public decimal? ValueTo { get; set; }
        public long? CurrencyId { get; set; }
        public long? DiscountValue { get; set; }
        public long? DiscountType { get; set; }
        public long? NetworkValue { get; set; }
        public long? Consumables { get; set; }
        public long? Consumables2 { get; set; }
        public long? Consumables3 { get; set; }
        public string ImageFile { get; set; }
        public string ImageFileDiscounted { get; set; }
        public string ImageFilePromo { get; set; }
        public string ImageFileOriginal { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public BusinessPackageCalculationMethod CalculationMethod { get; set; }

        public virtual TblCurrency Currency { get; set; }
        public virtual TblBusinessPackageType PackageType { get; set; }
        public virtual ICollection<TblIncomeDistribution> TblIncomeDistribution { get; set; }
        public virtual ICollection<TblUserBusinessPackage> TblUserBusinessPackage { get; set; }
    }
}
