using Ark.Entities.DTO;
using Ark.Entities.BO;
using Ark.Entities.Enums;
using Ark.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Ark.AppService
{
    public class UserIncomeAppService
    {
        public bool ExecuteIncomeDistribution(TblUserAuth userAuth, TblUserBusinessPackage userBusinessPackage, decimal amountPaid, ArkContext db, string EnvUrl)
        {
            BusinessPackageRepository businessPackageRepository = new BusinessPackageRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();
            List<TblIncomeType> incomeTypes = businessPackageRepository.GetIncomeTypes(userBusinessPackage.BusinessPackage, db);


            foreach (var incomeType in incomeTypes)
            {
                switch (incomeType.IncomeTypeCode)
                {
                    case IncomeType.DSI:
                        DirectIncome(userAuth, incomeTypeRepository.GetDistribution(incomeType.IncomeTypeCode, userBusinessPackage.BusinessPackage, db), amountPaid, db);
                        break;
                    case IncomeType.USI:
                        UniLevelIncome(userAuth, incomeTypeRepository.GetDistribution(incomeType.IncomeTypeCode, userBusinessPackage.BusinessPackage, db), amountPaid, db);
                        break;
                    case IncomeType.MSI:
                        MatchingIncome(userAuth, incomeTypeRepository.GetDistribution(incomeType.IncomeTypeCode, userBusinessPackage.BusinessPackage, db), amountPaid, db);
                        break;
                    case IncomeType.TMI:
                        TrimatchSalesIncome(userAuth, incomeTypeRepository.GetDistribution(incomeType.IncomeTypeCode, userBusinessPackage.BusinessPackage, db), amountPaid, EnvUrl, db);
                        break;
                    case IncomeType.GSI:
                        GlobalSalesIncome(userAuth, incomeTypeRepository.GetDistribution(incomeType.IncomeTypeCode, userBusinessPackage.BusinessPackage, db), amountPaid, db);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }
        public List<ShopUserCommissionItemBO> ExecuteCommissionDistribution(TblUserAuth userAuth, TblUserBusinessPackage userBusinessPackage, decimal amountPaid, ArkContext db)
        {
            BusinessPackageRepository businessPackageRepository = new BusinessPackageRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();
            List<ShopUserCommissionItemBO> shopUserCommissionItem = new List<ShopUserCommissionItemBO>();

            shopUserCommissionItem = ProductSalesCommission(userAuth, new TblIncomeDistribution { IncomeType = new TblIncomeType { IncomeTypeCode = IncomeType.PSI } }, amountPaid, db);

            return shopUserCommissionItem;
        }
        private bool DirectIncome(TblUserAuth userAuth, TblIncomeDistribution incomeDistribution, decimal amountPaid, ArkContext db)
        {
            UserAuthRepository userAuthRepository = new UserAuthRepository();
            UserMapRepository userMapRepository = new UserMapRepository();
            UserBusinessPackageRepository userBusinessPackageRepository = new UserBusinessPackageRepository();

            userAuth = userAuthRepository.GetByID(userAuth.Id, db);
            TblUserMap userMap = userMapRepository.Get(userAuth, db);

            int minUserCount = 1;

            // Get directs count
            List<TblUserBusinessPackage> userBusinessPackage = userBusinessPackageRepository.GetAllUserPackages(userAuth, db);

            CalculateIncomeBO calculateIncome = CalculateIncome_v2(incomeDistribution, userBusinessPackage, amountPaid);
            DistributeToWallet((long)userMap.SponsorUserId, userAuth.Id, calculateIncome, incomeDistribution, db);

            //if (minimumUserCheckBO.IsPassed)
            //{
            //    CalculateIncomeBO calculateIncome = CalculateIncome_v2(incomeDistribution, minimumUserCheckBO.userBusinessPackages, amountPaid);
            //    DistributeToWallet((long)userMap.SponsorUserId, userAuth.Id, calculateIncome, incomeDistribution, db);
            //}

            return true;
        }
        private bool UniLevelIncome(TblUserAuth userAuth, TblIncomeDistribution incomeDistribution, decimal amountPaid, ArkContext db)
        {
            throw new NotImplementedException();
        }
        private bool MatchingIncome(TblUserAuth userAuth, TblIncomeDistribution incomeDistribution, decimal amountPaid, ArkContext db)
        {
            throw new NotImplementedException();
        }
        private bool GlobalSalesIncome(TblUserAuth userAuth, TblIncomeDistribution incomeDistribution, decimal amountPaid, ArkContext db)
        {
            throw new NotImplementedException();
        }
        private bool TrimatchSalesIncome(TblUserAuth userAuth, TblIncomeDistribution incomeDistribution, decimal amountPaid, string EnvUrl, ArkContext db)
        {
            UserAuthRepository userAuthRepository = new UserAuthRepository();
            UserMapRepository userMapRepository = new UserMapRepository();

            userAuth = userAuthRepository.GetByID(userAuth.Id, db);
            TblUserMap userMap = userMapRepository.Get(userAuth, db);

            int minUserCount = 9;
            List<TblUserBusinessPackage> userBusinessPackages = userMapRepository.GetAllActivated(new TblUserMap { SponsorUserId = userMap.SponsorUserId }, db);
            MinimumUserCheckBO minimumUserCheckBO = MinimumUserCheck(userBusinessPackages, minUserCount);

            if (minimumUserCheckBO.IsPassed)
            {
                CalculateIncomeBO calculateIncome = CalculateIncome_v2(incomeDistribution, minimumUserCheckBO.userBusinessPackages, amountPaid);
                decimal _ArkCredits = calculateIncome.IncomeAmount * 0.30m;
                decimal _ArkCash = calculateIncome.IncomeAmount * 0.70m;

                calculateIncome.IncomeAmount = _ArkCash;
                calculateIncome.Remarks = String.Format("{0} ({1})", calculateIncome.Remarks, "70%");
                DistributeToWallet((long)userMap.SponsorUserId, userAuth.Id, calculateIncome, incomeDistribution, db);

                TblUserAuth userAuth2 = userAuthRepository.GetByID((long)userMap.SponsorUserId, db);
                ShopAppService shopAppService = new ShopAppService();
                shopAppService.UpdateUserWallet(new ShopUserCommissionItemBO
                {
                    ShopUserId = userAuth2.ShopUserId,
                    Reward = _ArkCredits,
                    Remarks = String.Format("{0} ({1})", incomeDistribution.IncomeType.IncomeTypeName, "30%"),
                    Computation = String.Format("{0} ({1})", calculateIncome.Remarks, " * (0.30)"),
                    Origin = incomeDistribution.IncomeType.IncomeTypeName
                }, EnvUrl);
            }

            return true;
        }
        private List<ShopUserCommissionItemBO> ProductSalesCommission(TblUserAuth userAuth, TblIncomeDistribution _incomeDistribution, decimal amountPaid, ArkContext db)
        {
            UserAuthRepository userAuthRepository = new UserAuthRepository();
            UserMapRepository userMapRepository = new UserMapRepository();
            IncomeTypeRepository incomeTypeRepository = new IncomeTypeRepository();
            UserBusinessPackageRepository userBusinessPackageRepository = new UserBusinessPackageRepository();

            userAuth = userAuthRepository.GetByID(userAuth.Id, db);
            TblUserMap userMap = userMapRepository.Get(userAuth, db);
            CalculateIncomeBO calculateIncome = new CalculateIncomeBO();
            List<ShopUserCommissionItemBO> shopUserCommissionItem = new List<ShopUserCommissionItemBO>();

            TblIncomeDistribution incomeDistribution = new TblIncomeDistribution();

            for (int i = 0; i < 3; i++)
            {
                if (userMap != null)
                {
                    userMap = userMapRepository.Get(new TblUserAuth { Id = (long)userMap.SponsorUserId }, db);
                    TblUserBusinessPackage userBusinessPackage = userMap != null ? userBusinessPackageRepository.Get(new TblUserAuth { Id = userMap.Id }, db) : null;

                    if (userBusinessPackage != null)
                    {
                        _incomeDistribution = incomeTypeRepository.GetDistribution(IncomeType.PSI, userBusinessPackage.BusinessPackage, db);

                        if (_incomeDistribution != null)
                        {
                            incomeDistribution.Value = _incomeDistribution.Value;
                            incomeDistribution.IncomeTypeId = _incomeDistribution.IncomeTypeId;
                            incomeDistribution.DistributionType = _incomeDistribution.DistributionType;

                            switch (userBusinessPackage.BusinessPackage.PackageCode)
                            {
                                case "EPKG3":
                                    switch (i)
                                    {
                                        case 0:
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                        default:
                                            incomeDistribution.Value = incomeDistribution.Value - i;
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                    }
                                    break;
                                case "EPKG2":
                                    switch (i)
                                    {
                                        case 0:
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                        default:
                                            incomeDistribution.Value = incomeDistribution.Value - i;
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                    }
                                    break;
                                case "EPKG1":
                                    switch (i)
                                    {
                                        case 0:
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                        default:
                                            incomeDistribution.Value = incomeDistribution.Value - (0.5m * i);
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                    }
                                    break;
                                case "EPKG1TRL":
                                    switch (i)
                                    {
                                        case 0:
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                        default:
                                            incomeDistribution.Value = incomeDistribution.Value - (0.5m * i);
                                            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            shopUserCommissionItem.Add(new ShopUserCommissionItemBO
                            {
                                Reward = calculateIncome.IncomeAmount,
                                ShopUserId = userMap.IdNavigation.ShopUserId
                            });

                            DistributeToWallet((long)userMap.IdNavigation.Id, userAuth.Id, calculateIncome, incomeDistribution, db);
                        }


                    }

                }





            }

            return shopUserCommissionItem;
        }
        private bool ProductSalesRebates(TblUserAuth userAuth, TblIncomeDistribution incomeDistribution, decimal amountPaid, ArkContext db)
        {
            UserAuthRepository userAuthRepository = new UserAuthRepository();
            UserMapRepository userMapRepository = new UserMapRepository();

            userAuth = userAuthRepository.GetByID(userAuth.Id, db);
            TblUserMap userMap = userMapRepository.Get(userAuth, db);

            CalculateIncomeBO calculateIncome = new CalculateIncomeBO();
            calculateIncome = CalculateProductCommission(incomeDistribution, amountPaid);

            DistributeToWallet((long)userMap.SponsorUserId, userAuth.Id, calculateIncome, incomeDistribution, db);

            return true;
        }
        private MinimumUserCheckBO MinimumUserCheck(List<TblUserBusinessPackage> userBusinessPackages, int minUserCount)
        {
            MinimumUserCheckBO minimumUserCheckBO = new MinimumUserCheckBO() { IsPassed = false };
            if (minUserCount != 0)
            {
                decimal _ck = userBusinessPackages.Count % minUserCount;


                if (userBusinessPackages.Count >= minUserCount && _ck == 0)
                {

                    int _removeUserCount = userBusinessPackages.Count / minUserCount > 1 ? minUserCount * (userBusinessPackages.Count / minUserCount) : 0;

                    if (_removeUserCount > 0)
                    {
                        userBusinessPackages.RemoveAll(i => i.Id <= (userBusinessPackages[0].Id + _removeUserCount));
                    }
                    minimumUserCheckBO.IsPassed = true;
                    minimumUserCheckBO.userBusinessPackages = userBusinessPackages;
                }
            }
            else
            {
                minimumUserCheckBO.IsPassed = true;
                minimumUserCheckBO.userBusinessPackages = userBusinessPackages;
            }
            return minimumUserCheckBO;

        }
        private CalculateIncomeBO CalculateIncome(TblIncomeDistribution incomeDistribution, decimal amountPaid)
        {
            CalculateIncomeBO calculateIncome = new CalculateIncomeBO(); ;

            switch (incomeDistribution.DistributionType)
            {
                case IncomeDistributionType.Fixed:
                    calculateIncome.IncomeAmount = incomeDistribution.Value;
                    calculateIncome.Remarks = String.Format("Value = ({0})", incomeDistribution.Value);
                    break;
                case IncomeDistributionType.Percentage:

                    switch (incomeDistribution.BusinessPackage.CalculationMethod)
                    {
                        case BusinessPackageCalculationMethod.NetworkValue:
                            calculateIncome.IncomeAmount = ((decimal)incomeDistribution.BusinessPackage.NetworkValue / 100) * (incomeDistribution.Value / 100);
                            calculateIncome.Remarks = String.Format("Value = ({0}) * ({1})", ((decimal)incomeDistribution.BusinessPackage.NetworkValue / 100), (incomeDistribution.Value / 100));
                            break;
                        case BusinessPackageCalculationMethod.PaymentValue:
                            calculateIncome.IncomeAmount = (incomeDistribution.Value / 100) * amountPaid;
                            calculateIncome.Remarks = String.Format("Value = ({0}) * ({1})", (incomeDistribution.Value / 100), amountPaid);
                            break;
                        default:
                            break;
                    }


                    break;
                default:
                    break;
            }
            return calculateIncome;
        }
        private CalculateIncomeBO CalculateProductCommission(TblIncomeDistribution incomeDistribution, decimal amountPaid)
        {
            CalculateIncomeBO calculateIncome = new CalculateIncomeBO(); ;

            switch (incomeDistribution.DistributionType)
            {
                case IncomeDistributionType.Fixed:
                    calculateIncome.IncomeAmount = incomeDistribution.Value;
                    calculateIncome.Remarks = String.Format("Value = ({0})", incomeDistribution.Value);
                    break;
                case IncomeDistributionType.Percentage:
                    calculateIncome.IncomeAmount = (incomeDistribution.Value / 100) * amountPaid;
                    calculateIncome.Remarks = String.Format("Value = ({0}) * ({1})", (incomeDistribution.Value / 100), amountPaid);

                    break;
                default:
                    break;
            }
            return calculateIncome;
        }
        private CalculateIncomeBO CalculateIncome_v2(TblIncomeDistribution incomeDistribution, List<TblUserBusinessPackage> userBusinessPackages, decimal amountPaid)
        {
            CalculateIncomeBO calculateIncome = new CalculateIncomeBO(); ;

            switch (incomeDistribution.DistributionType)
            {
                case IncomeDistributionType.Fixed:
                    calculateIncome.IncomeAmount = incomeDistribution.Value;
                    calculateIncome.Remarks = String.Format("Value = ({0})", incomeDistribution.Value);
                    break;
                case IncomeDistributionType.Percentage:

                    switch (incomeDistribution.BusinessPackage.CalculationMethod)
                    {
                        case BusinessPackageCalculationMethod.NetworkValue:
                            calculateIncome.IncomeAmount = (decimal)userBusinessPackages.Sum(i => i.BusinessPackage.NetworkValue) * ((decimal)incomeDistribution.Value / 100) * (0.9m);
                            calculateIncome.Remarks = String.Format("Value = ({0}) * ({1}) * ({2})", (decimal)userBusinessPackages.Sum(i => i.BusinessPackage.NetworkValue), ((decimal)incomeDistribution.Value / 100), (0.9m));
                            break;
                        case BusinessPackageCalculationMethod.PaymentValue:
                            calculateIncome.IncomeAmount = (incomeDistribution.Value / 100) * amountPaid * (0.9m);
                            calculateIncome.Remarks = String.Format("Value = ({0}) * ({1}) * ({2})", (incomeDistribution.Value / 100), amountPaid, (0.9m));
                            break;
                        default:
                            break;
                    }


                    break;
                default:
                    break;
            }
            return calculateIncome;
        }
        private bool DistributeToWallet(long recepientAuthId, long sourceAuthId, CalculateIncomeBO calculateIncome, TblIncomeDistribution incomeDistribution, ArkContext db)
        {
            UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
            UserWalletAppService userWalletAppService = new UserWalletAppService();

            UserWalletBO userWallet = new UserWalletBO
            {
                UserAuthId = recepientAuthId,
                WalletTypeId = (long)WalletTypeID.ArkCash
            };

            WalletTransactionBO walletTransaction = new WalletTransactionBO
            {
                From = sourceAuthId.ToString(),
                Amount = calculateIncome.IncomeAmount,
                Remarks = calculateIncome.Remarks
            };

            userIncomeTransactionRepository.Create(userWallet, walletTransaction, incomeDistribution, db);
            userWalletAppService.Increment(userWallet, walletTransaction, db);

            return true;

        }
        public List<TblUserIncomeTransaction> GetUserIncomeTransactions(TblUserAuth userAuth, ArkContext db = null)
        {
            if (db != null)
            {
                UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
                return userIncomeTransactionRepository.GetAll(userAuth, db);
            }
            else
            {
                using (db = new DataAccessLayer.ArkContext())
                {
                    UserIncomeTransactionRepository userIncomeTransactionRepository = new UserIncomeTransactionRepository();
                    return userIncomeTransactionRepository.GetAll(userAuth, db);
                }
            }


        }

    }
}
