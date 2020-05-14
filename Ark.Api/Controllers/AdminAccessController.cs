using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ark.AppService;
using Ark.Entities.BO;
using Ark.Entities.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ark.Entities.Enums;

namespace Ark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAccessController : ControllerBase
    {
        [HttpGet("UserList")]
        public ActionResult UserList()
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                _apiResponse.UserList = adminAccessAppService.GetAllUsers();
                _apiResponse.UserDepositRequests = adminAccessAppService.GetAllDepositRequest();

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpGet("GetUserBusinessPackageSales")]
        public ActionResult GetUserBusinessPackageSales()
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                _apiResponse.GetUserBusinessPackageSales = adminAccessAppService.GetUserBusinessPackageSales();

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpGet("GetBusinessPackageSales")]
        public ActionResult GetBusinessPackageSales()
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                _apiResponse.GetBusinessPackageSales = adminAccessAppService.GetBusinessPackageSales();

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("SingleUser")]
        public ActionResult SingleUser([FromBody] UserBO userBO)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserIncomeAppService userIncomeAppService = new UserIncomeAppService();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                if (userBO.ShopUserId != 0)
                {
                    _apiResponse.User = adminAccessAppService.GetUserByShopID(userBO);
                }
                else
                {
                    _apiResponse.User = adminAccessAppService.GetUserByUid(userBO);
                }

                _apiResponse.UserWallets = adminAccessAppService.GetUserWallets(new TblUserAuth { Id = _apiResponse.User.Id });
                _apiResponse.UserIncomeTransactions = userIncomeAppService.GetUserIncomeTransactions(new TblUserAuth { Id = _apiResponse.User.Id });

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("EndTrial")]
        public ActionResult EndTrial([FromBody] UserBO userBO)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
            try
            {
                if (userBO.ShopUserId != 0)
                {
                    _apiResponse.User = adminAccessAppService.GetUserByShopID(userBO);
                }
                else
                {
                    _apiResponse.User = adminAccessAppService.GetUserByUid(userBO);
                }
                adminAccessAppService.EndTrial(userBO);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("TransferBalance")]
        public ActionResult TransferBalance([FromBody] TransferBalanceBO transferBalance)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserIncomeAppService userIncomeAppService = new UserIncomeAppService();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                adminAccessAppService.TransferBalance(transferBalance);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("IncrementBalance")]
        public ActionResult IncrementBalance([FromBody] TransferBalanceBO transferBalance)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserIncomeAppService userIncomeAppService = new UserIncomeAppService();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                adminAccessAppService.IncrementBalance(transferBalance);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("DecrementBalance")]
        public ActionResult DecrementBalance([FromBody] TransferBalanceBO transferBalance)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserIncomeAppService userIncomeAppService = new UserIncomeAppService();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                adminAccessAppService.DecrementBalance(transferBalance);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }
        [HttpPost("WithdrawBalance")]
        public ActionResult WithdrawBalance([FromBody] TransferBalanceBO transferBalance)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserIncomeAppService userIncomeAppService = new UserIncomeAppService();
            try
            {
                AdminAccessAppService adminAccessAppService = new AdminAccessAppService();
                adminAccessAppService.WithdrawBalance(transferBalance);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpGet("WithdrawalList")]
        public ActionResult WithdrawalList()
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            try
            {
                UserWithdrawalRequestAppService userWithdrawalRequest = new UserWithdrawalRequestAppService();
                _apiResponse.UserWithdrawalRequests = userWithdrawalRequest.GetAll();

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("CreateWithdrawalRequest")]
        public ActionResult CreateWithdrawalRequest([FromBody] TblUserWithdrawalRequest userWithdrawalRequest)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserWithdrawalRequestAppService userWithdrawalRequestAppService = new UserWithdrawalRequestAppService();
            try
            {
                userWithdrawalRequestAppService.Create(userWithdrawalRequest);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }

        [HttpPost("UpdateWithdrawalRequest")]
        public ActionResult UpdateWithdrawalRequest([FromBody] TblUserWithdrawalRequest userWithdrawalRequest)
        {
            AdminResponseBO _apiResponse = new AdminResponseBO();
            UserWithdrawalRequestAppService userWithdrawalRequestAppService = new UserWithdrawalRequestAppService();
            try
            {
                userWithdrawalRequestAppService.Update(userWithdrawalRequest);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Message = "Status Successfully Updated!";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }
    }
}
