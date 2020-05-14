using Ark.DataAccessLayer;
using Ark.Entities.BO;
using Ark.Entities.DTO;
using Ark.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ark.AppService
{
   public class UserWithdrawalRequestAppService
    {
        public List<TblUserWithdrawalRequest> GetAll()
        {
            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserWithdrawalRequestRepository userWithdrawalRequestRepository = new UserWithdrawalRequestRepository();
                    return userWithdrawalRequestRepository.GetAll(db);
                }
            }
        }

        public bool Update(TblUserWithdrawalRequest userWithdrawalRequest)
        {
            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserWithdrawalRequestRepository userWithdrawalRequestRepository = new UserWithdrawalRequestRepository();

                    TblUserWithdrawalRequest tblUserWithdrawal = userWithdrawalRequestRepository.Get(userWithdrawalRequest, db);
                    tblUserWithdrawal.WithdrawalStatus = userWithdrawalRequest.WithdrawalStatus;

                    userWithdrawalRequestRepository.Update(tblUserWithdrawal, db);

                    transaction.Commit();
                    return true;
                }
            }
        }

        public bool Create(TblUserWithdrawalRequest userWithdrawalRequest)
        {
            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserWithdrawalRequestRepository userWithdrawalRequestRepository = new UserWithdrawalRequestRepository();
                    AdminAccessAppService adminAccessAppService = new AdminAccessAppService();

                    UserBO targetUser = adminAccessAppService.GetUserByShopID(new UserBO { ShopUserId = userWithdrawalRequest.UserAuthId });

                    userWithdrawalRequest.UserAuthId = targetUser.Id;
                    userWithdrawalRequest.WithdrawalStatus = (short)WithdrawalRequestStatus.Pending;
                    userWithdrawalRequest.TargetCurrencyId = 3;
                    userWithdrawalRequestRepository.Create(userWithdrawalRequest, db);

                    transaction.Commit();
                    return true;
                }
            }
        }


    }
}
