namespace Ark.Entities.DTO
{
    using Ark.Entities.Enums;
    using System;
    using System.Collections.Generic;

    public partial class TblIncomeDistribution
    {
        public long Id { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? LastChanged { get; set; }
        public long BusinessPackageId { get; set; }
        public long IncomeTypeId { get; set; }
        public  decimal Value { get; set; }
        public IncomeDistributionType DistributionType { get; set; }

        public virtual TblBusinessPackage BusinessPackage { get; set; }
        public virtual TblIncomeType IncomeType { get; set; }
    }
}
