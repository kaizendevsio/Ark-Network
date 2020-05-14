using Ark.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ark.Entities.BO
{
    public class AdminResponseBO : ApiResponseBO
    {
        public UserBO User { get; set; }
        public List<UserWalletBO> UserWallets { get; set; }
        public List<UserBO> UserList { get; set; }
        public List<UserBO> UserDepositRequests { get; set; }
        public List<TblUserIncomeTransaction> UserIncomeTransactions { get; set; }
        public List<TblUserWithdrawalRequest> UserWithdrawalRequests { get; set; }
        public List<TblUserBusinessPackage> GetUserBusinessPackageSales { get; set; }
        public List<BusinessPackageSalesBO> GetBusinessPackageSales { get; set; }
    }
}
