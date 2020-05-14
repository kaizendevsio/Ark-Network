using Ark.Entities.DTO;
using Ark.Entities.BO;
using Ark.Entities.Enums;
using Ark.DataAccessLayer;
using System.Collections.Generic;
using System;
using SendGrid;
using System.Threading.Tasks;

namespace Ark.AppService
{
    public class UserAppService
    {
        public UserResponseBO Authenticate(UserBO userBO)
        {
            using (var db = new DataAccessLayer.ArkContext())
            {
                UserAuthRepository userAuthRepository = new UserAuthRepository();
                TblUserAuth userAuth = userAuthRepository.Get(userBO, db);

                UserInfoRepository userInfoRepository = new UserInfoRepository();
                TblUserInfo userInfo = userInfoRepository.Get(userAuth, db);

                // ENFORECE EMAIL VERIFICATION
                if (userInfo.EmailStatus == (short)EmailStatus.Unverified)
                {
                    throw new ArgumentException("Email Not Verified");
                }

                if (userAuth.LoginStatus != LoginStatus.Enabled)
                {
                    throw new ArgumentException(String.Format("{0} {1}", "Your account has been", userAuth.LoginStatus.ToString().ToLower()));
                }

                UserWalletRepository userWalletRepository = new UserWalletRepository();
                List<UserWalletBO> userWallet = userWalletRepository.GetAllBO(userAuth, db);

                UserRoleRepository userRoleRepository = new UserRoleRepository();
                TblUserRole userRole = userRoleRepository.Get(userAuth, db);

                UserResponseBO userAuthResponse = new UserResponseBO();

                userAuthResponse.UserInfo = userInfo;
                userAuthResponse.UserWallet = userWallet;
                userAuthResponse.UserAuth = userAuth;
                userAuthResponse.UserRole = userRole;

                return userAuthResponse;
            }
        }
        public async Task<bool> CreateAsync(UserBO userBO, string EnvUrl, DataAccessLayer.ArkContext db = null)
        {
            if (db != null)
            {
                UserInfoRepository userInfoRepository = new UserInfoRepository();

                TblUserInfo userInfo = userInfoRepository.Create(userBO, db);
                userBO.Uid = userInfo.Uid;

                UserAuthRepository userAuthRepository = new UserAuthRepository();
                TblUserAuth userAuth = userAuthRepository.Create(userBO, userInfo, db);

                UserRoleRepository userRoleRepository = new UserRoleRepository();
                userRoleRepository.Create(userAuth, db);

                // CREATE USER WALLETS
                UserWalletAppService userWallet = new UserWalletAppService();
                userWallet.Create(userAuth, db);

                UserWalletAddressAppService userWalletAddressAppService = new UserWalletAddressAppService();
                bool r = await userWalletAddressAppService.Create(userAuth,"BTC");

                UserMapAppService userMapAppService = new UserMapAppService();
                userMapAppService.Create(userBO, userAuth, db);

                return true;
            }
            else
            {
                using (db = new DataAccessLayer.ArkContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        UserInfoRepository userInfoRepository = new UserInfoRepository();
                        MailAppService mailAppService = new MailAppService();

                        TblUserInfo userInfo = userInfoRepository.Create(userBO, db);
                        userBO.Uid = userInfo.Uid;

                        UserAuthRepository userAuthRepository = new UserAuthRepository();
                        TblUserAuth userAuth = userAuthRepository.Create(userBO, userInfo, db);

                        UserRoleRepository userRoleRepository = new UserRoleRepository();
                        userRoleRepository.Create(userAuth, db);

                        // CREATE USER WALLETS
                        UserWalletAppService userWallet = new UserWalletAppService();
                        userWallet.Create(userAuth, db);
                        
                        UserMapAppService userMapAppService = new UserMapAppService();
                        userMapAppService.Create(userBO, userAuth, db);

                        transaction.Commit();

                        BusinessPackageRepository businessPackageRepository = new BusinessPackageRepository();
                        TblBusinessPackage businessPackage = businessPackageRepository.Get(new TblBusinessPackage { PackageCode = "EPKG1TRL" }, db);

                        if (DateTime.Now < businessPackage.ExpiryDate)
                        {
                            UserBusinessPackageAppService userBusinessPackageAppService = new UserBusinessPackageAppService();
                            TblUserDepositRequest tblUserDepositRequest = userBusinessPackageAppService.Create(new UserBusinessPackageBO
                            {
                                DepositStatus = DepositStatus.PendingPayment,
                                FromWalletCode = "TLI",
                                Id = userAuth.Id,
                                BusinessPackageID = 6,
                                FromCurrencyIso3 = "PHP",
                                AmountPaid = 0,
                            }, EnvUrl); ;

                            userBusinessPackageAppService.Update(new UserBusinessPackageBO
                            {
                                AmountPaid = 0,
                                UserPackageID = (long)tblUserDepositRequest.SourceCurrencyId,
                                DepositStatus = DepositStatus.Paid
                            }, EnvUrl);
                        }
                        

                        
                        return true;
                    }
                }
            }

        }
        public TblUserInfo Get(TblUserAuth userAuth)
        {
            using (var db = new DataAccessLayer.ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {

                    UserInfoRepository userInfoRepository = new UserInfoRepository();
                    TblUserInfo userInfo = userInfoRepository.Get(userAuth, db);

                    return userInfo;
                }
            }
        }
        public TblUserRole GetUserRole(TblUserAuth userAuth)
        {
            using (var db = new DataAccessLayer.ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {

                    UserRoleRepository userRoleRepository = new UserRoleRepository();
                    TblUserRole userRole = userRoleRepository.Get(userAuth, db);

                    return userRole;
                }
            }
        }
        public bool VerifyEmail(TblUserAuth userAuth)
        {
            using (var db = new DataAccessLayer.ArkContext())   
            {
                using (var transaction = db.Database.BeginTransaction())
                {

                    UserInfoRepository userInfoRepository = new UserInfoRepository();
                    userInfoRepository.VerifyEmail(userAuth, db);

                    transaction.Commit();
                    return true;
                }
            }


        }
        public bool Update(UserBO userBO)
        {
            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserAuthRepository userAuthRepository = new UserAuthRepository();

                    TblUserAuth userAuth = userAuthRepository.GetByShopID(userBO.ShopUserId, db);
                    TblUserInfo userInfo = userAuth.UserInfo;

                    userAuth.UserName = userBO.Email;

                    userInfo.FirstName = userBO.FirstName;
                    userInfo.LastName = userBO.LastName;
                    userInfo.PhoneNumber = userBO.PhoneNumber;
                    userInfo.Email = userBO.Email;
                    userInfo.ModifiedOn = DateTime.Now;

                    userAuthRepository.Update(userAuth, db);

                    transaction.Commit();
                    return true;
                }
            }
        }
        public bool AuthStatusChange(UserBO userBO)
        {
            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserAuthRepository userAuthRepository = new UserAuthRepository();

                    TblUserAuth userAuth = userAuthRepository.GetByShopID(userBO.ShopUserId, db);
                    userAuth.LoginStatus = (LoginStatus)userBO.LoginStatus;
                    userAuthRepository.Update(userAuth, db);

                    transaction.Commit();
                    return true;
                }
            }
        }
        public bool PasswordChange(UserBO userBO)
        {
            using (var db = new ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    UserAuthRepository userAuthRepository = new UserAuthRepository();

                    TblUserAuth userAuth = userAuthRepository.GetByShopID(userBO.ShopUserId, db);
                    userAuthRepository.UpdatePassword(userBO.PasswordString, userAuth, db);
                    
                    transaction.Commit();
                    return true;
                }
            }
        }
        public bool StructureMapTesting(StructureMapInjection structureMap, string EnvUrl)
        {
            UserAppService userAppService = new UserAppService();

            int BinaryCount = structureMap.BinarySponsorDataArray.Count;
            int UnilevelCount = structureMap.DirectSponsorDataArray.Count;
            TblUserInfo userInfoBinarySponsor = new TblUserInfo();
            TblUserInfo userInfoDirectSponsor = new TblUserInfo();
            TblUserAuth userAuth = new TblUserAuth();

            using (var db = new DataAccessLayer.ArkContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    for (int i = 0; i < BinaryCount; i++)
                    {
                        if (structureMap.BinarySponsorDataArray[i].Parent == 0)
                        {
                            userInfoBinarySponsor = new TblUserInfo();
                        }
                        else
                        {
                            userAuth.UserName = structureMap.BinarySponsorDataArray[structureMap.BinarySponsorDataArray[i].Parent - 1].Name;
                            userInfoBinarySponsor = userAppService.Get(userAuth);
                        }
                        if (structureMap.DirectSponsorDataArray[i].Parent == 0)
                        {
                            userInfoDirectSponsor = new TblUserInfo();
                        }
                        else
                        {
                            userAuth.UserName = structureMap.DirectSponsorDataArray[structureMap.DirectSponsorDataArray[i].Parent - 1].Name;
                            userInfoDirectSponsor = userAppService.Get(userAuth);
                        }

                        UserBO user = new UserBO();
                        user.FirstName = structureMap.BinarySponsorDataArray[i].Name;
                        user.LastName = "User";
                        user.UserName = structureMap.BinarySponsorDataArray[i].Name;
                        user.Email = string.Format("{0}{1}", structureMap.BinarySponsorDataArray[i].Name, "@mail.com");
                        user.PasswordString = "123";
                        user.DirectSponsorID = userInfoDirectSponsor.Uid;
                        user.BinarySponsorID = userInfoBinarySponsor.Uid;
                        user.BinaryPosition = structureMap.BinarySponsorDataArray[i].Comments;

                        userAppService.CreateAsync(user, EnvUrl);
                    }

                    transaction.Commit();
                }
            }



            return true;
        }
    }
}
