using System;

namespace Ark.Entities.BO
{
    public class TransferBalanceBO
    {
        public long SourceShopId { get; set; }
        public long TargetShopId { get; set; }
        public decimal Amount { get; set; }
    }
}
