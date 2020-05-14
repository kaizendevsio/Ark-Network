using Ark.Entities.DTO;
using Ark.Entities.BO;
using Ark.Entities.Enums;
using Ark.DataAccessLayer;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Ark.AppService
{
    public class AdminAccessAppService
    {
        public List<UserBO> GetAllUsers(ArkContext db = null)
        {
            using (db = new DataAccessLayer.ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserInfoRepository userInfoRepository = new UserInfoRepository();
                    return userInfoRepository.GetAll(db);
                }
            }

        }
        public List<UserBO> GetAllDepositRequest(ArkContext db = null)
        {
            using (db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserInfoRepository userInfoRepository = new UserInfoRepository();
                    return userInfoRepository.GetAllDeposit(db);
                }
            }
        }
        public List<TblUserBusinessPackage> GetUserBusinessPackageSales(ArkContext db = null)
        {
            using (db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserBusinessPackageRepository userBusinessPackageRepository = new UserBusinessPackageRepository();
                    return userBusinessPackageRepository.GetUserBusinessPackageSales(db);
                }
            }
        }
        public List<BusinessPackageSalesBO> GetBusinessPackageSales(ArkContext db = null)
        {
            using (db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    BusinessPackageRepository businessPackageRepository = new BusinessPackageRepository();
                    return businessPackageRepository.GetBusinessPackageSales(db);
                }
            }
        }
        public UserBO GetUserByShopID(UserBO userBO, ArkContext db = null)
        {
            using (db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserAuthRepository userAuthRepository = new UserAuthRepository();
                    TblUserAuth userAuth = userAuthRepository.GetByShopID(userBO.ShopUserId, db);

                    UserBO user = new UserBO
                    {
                        UserName = userAuth.UserName,
                        ShopUserId = userAuth.ShopUserId,
                        LoginStatus = (short)userAuth.LoginStatus,
                        FirstName = userAuth.UserInfo.FirstName,
                        LastName = userAuth.UserInfo.LastName,
                        Uid = userAuth.UserInfo.Uid,
                        Dob = userAuth.UserInfo.Dob,
                        CreatedOn = userAuth.CreatedOn,
                        Email = userAuth.UserInfo.Email,
                        Gender = userAuth.UserInfo.Gender,
                        CountryIsoCode2 = userAuth.UserInfo.CountryIsoCode2,
                        EmailStatus = userAuth.UserInfo.EmailStatus,
                        PhoneNumber = userAuth.UserInfo.PhoneNumber,
                        Id = userAuth.Id
                    };

                    return user;
                }
            }
        }
        public UserBO GetUserByUid(UserBO userBO, ArkContext db = null)
        {
            using (db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserAuthRepository userAuthRepository = new UserAuthRepository();
                    TblUserAuth userAuth = userAuthRepository.GetByUID(userBO.Uid, db);

                    UserBO user = new UserBO
                    {
                        UserName = userAuth.UserName,
                        ShopUserId = userAuth.ShopUserId,
                        LoginStatus = (short)userAuth.LoginStatus,
                        FirstName = userAuth.UserInfo.FirstName,
                        LastName = userAuth.UserInfo.LastName,
                        Uid = userAuth.UserInfo.Uid,
                        Dob = userAuth.UserInfo.Dob,
                        CreatedOn = userAuth.CreatedOn,
                        Email = userAuth.UserInfo.Email,
                        Gender = userAuth.UserInfo.Gender,
                        CountryIsoCode2 = userAuth.UserInfo.CountryIsoCode2,
                        EmailStatus = userAuth.UserInfo.EmailStatus,
                        PhoneNumber = userAuth.UserInfo.PhoneNumber,
                        Id = userAuth.Id
                    };

                    return user;
                }
            }
        }
        public List<UserWalletBO> GetUserWallets(TblUserAuth userAuth, ArkContext db = null)
        {
            using (db = new ArkContext())
            {
                UserWalletRepository userWalletRepository = new UserWalletRepository();
                List<UserWalletBO> userWallet = userWalletRepository.GetAllBO(userAuth, db);

                return userWallet;
            }
        }
        public bool TransferBalance(TransferBalanceBO transferBalance)
        {
            UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
            UserWalletAppService userWalletAppService = new UserWalletAppService();
            WalletTypeRepository walletTypeRepository = new WalletTypeRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();

            UserBO sourceUser = GetUserByShopID(new UserBO { ShopUserId = transferBalance.SourceShopId });
            UserBO targetUser = GetUserByShopID(new UserBO { ShopUserId = transferBalance.TargetShopId });

            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    TblWalletType walletType = walletTypeRepository.Get(new UserWalletBO { WalletCode = "ACW", WalletTypeId = 0 }, db);
                    // SourceUser Transaction
                    var sourceUserWallet = new UserWalletBO
                    {
                        UserAuthId = sourceUser.Id,
                        WalletTypeId = walletType.Id
                    };
                    var targetUserWallet = new UserWalletBO
                    {
                        UserAuthId = targetUser.Id,
                        WalletTypeId = walletType.Id
                    };
                    var walletTransaction = new WalletTransactionBO
                    {
                        From = sourceUser.Id.ToString(),
                        Amount = transferBalance.Amount,
                        Remarks = "",
                        IsFeeEnabled = false
                    };
                    var incomeDistribution = new TblIncomeDistribution
                    {
                        IncomeTypeId = incomeTypeRepository.Get(new TblIncomeType { IncomeTypeShortName = "WBT" }, db).Id
                    };

                    userIncomeTransactionRepository.Create(targetUserWallet, walletTransaction, incomeDistribution, db);
                    userIncomeTransactionRepository.Create(sourceUserWallet, walletTransaction, incomeDistribution, db, true);
                    userWalletAppService.Transfer(sourceUserWallet, targetUserWallet, walletTransaction, db);

                    transaction.Commit();
                }
            }
            return true;
        }
        public bool IncrementBalance(TransferBalanceBO transferBalance)
        {
            UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
            UserWalletAppService userWalletAppService = new UserWalletAppService();
            WalletTypeRepository walletTypeRepository = new WalletTypeRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();

            // UserBO sourceUser = GetUserByShopID(new UserBO { ShopUserId = transferBalance.SourceShopId });
            UserBO targetUser = GetUserByShopID(new UserBO { ShopUserId = transferBalance.TargetShopId });

            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    TblWalletType walletType = walletTypeRepository.Get(new UserWalletBO { WalletCode = "ACW", WalletTypeId = 0 }, db);

                    var targetUserWallet = new UserWalletBO
                    {
                        UserAuthId = targetUser.Id,
                        WalletTypeId = walletType.Id
                    };
                    var walletTransaction = new WalletTransactionBO
                    {
                        From = targetUser.Id.ToString(),
                        Amount = transferBalance.Amount,
                        Remarks = ""
                    };
                    var incomeDistribution = new TblIncomeDistribution
                    {
                        IncomeTypeId = incomeTypeRepository.Get(new TblIncomeType { IncomeTypeShortName = "WTP" }, db).Id
                    };

                    userIncomeTransactionRepository.Create(targetUserWallet, walletTransaction, incomeDistribution, db);
                    userWalletAppService.Increment(targetUserWallet, walletTransaction, db);

                    // userIncomeTransactionRepository.Create(sourceUserWallet, walletTransaction, incomeDistribution, db, true);
                    // userWalletAppService.Decrement(sourceUserWallet, walletTransaction, db);

                    transaction.Commit();
                }
            }
            return true;
        }
        public bool DecrementBalance(TransferBalanceBO transferBalance)
        {
            UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
            UserWalletAppService userWalletAppService = new UserWalletAppService();
            WalletTypeRepository walletTypeRepository = new WalletTypeRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();

            UserBO targetUser = GetUserByShopID(new UserBO { ShopUserId = transferBalance.TargetShopId });

            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    TblWalletType walletType = walletTypeRepository.Get(new UserWalletBO { WalletCode = "ACW", WalletTypeId = 0 }, db);

                    var targetUserWallet = new UserWalletBO
                    {
                        UserAuthId = targetUser.Id,
                        WalletTypeId = walletType.Id
                    };
                    var walletTransaction = new WalletTransactionBO
                    {
                        From = targetUser.Id.ToString(),
                        Amount = transferBalance.Amount,
                        Remarks = ""
                    };
                    var incomeDistribution = new TblIncomeDistribution
                    {
                        IncomeTypeId = incomeTypeRepository.Get(new TblIncomeType { IncomeTypeShortName = "WBC" }, db).Id
                    };

                    // userIncomeTransactionRepository.Create(targetUserWallet, walletTransaction, incomeDistribution, db);
                    // userWalletAppService.Increment(targetUserWallet, walletTransaction, db);

                    userIncomeTransactionRepository.Create(targetUserWallet, walletTransaction, incomeDistribution, db, true);
                    userWalletAppService.Decrement(targetUserWallet, walletTransaction, db);

                    transaction.Commit();
                }
            }
            return true;
        }
        public bool WithdrawBalance(TransferBalanceBO transferBalance)
        {
            UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
            UserWalletAppService userWalletAppService = new UserWalletAppService();
            WalletTypeRepository walletTypeRepository = new WalletTypeRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();

            UserBO targetUser = GetUserByShopID(new UserBO { ShopUserId = transferBalance.TargetShopId });

            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    TblWalletType walletType = walletTypeRepository.Get(new UserWalletBO { WalletCode = "ACW", WalletTypeId = 0 }, db);

                    var targetUserWallet = new UserWalletBO
                    {
                        UserAuthId = targetUser.Id,
                        WalletTypeId = walletType.Id
                    };
                    var walletTransaction = new WalletTransactionBO
                    {
                        From = targetUser.Id.ToString(),
                        Amount = transferBalance.Amount,
                        Remarks = ""
                    };
                    var incomeDistribution = new TblIncomeDistribution
                    {
                        IncomeTypeId = incomeTypeRepository.Get(new TblIncomeType { IncomeTypeShortName = "WTB" }, db).Id
                    };

                    // userIncomeTransactionRepository.Create(targetUserWallet, walletTransaction, incomeDistribution, db);
                    // userWalletAppService.Increment(targetUserWallet, walletTransaction, db);

                    userIncomeTransactionRepository.Create(targetUserWallet, walletTransaction, incomeDistribution, db, true);
                    userWalletAppService.Decrement(targetUserWallet, walletTransaction, db);

                    transaction.Commit();
                }
            }
            return true;
        }
        public bool EndTrial(UserBO user)
        {
            UserBO targetUser = GetUserByShopID(user);
            var userBusinessPackageRepository = new UserBusinessPackageRepository();

            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    TblUserBusinessPackage userBusinessPackage = userBusinessPackageRepository.Get(new TblUserAuth { Id = targetUser.Id },db);
                    userBusinessPackageRepository.Delete(userBusinessPackage, db);
                    transaction.Commit();
                }
            }
            return true;
        }
    }
}
