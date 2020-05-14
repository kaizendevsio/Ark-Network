using Ark.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ark.Entities.BO
{
    public class WalletTransactionBO : BaseAuditBO
    {
        public string From { get; set; }
        public string To { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountOpposite
        {
            get
            {
                this._AmountOppposite = Math.Abs((decimal)this.Amount) * -1;
                return this._AmountOppposite;
            }
            set { return; }
        }
        public decimal _AmountOppposite { get; set; }
        public string TxHash { get; set; }
        public bool IsFeeEnabled { get; set; }
        public string Remarks { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
    }
}
