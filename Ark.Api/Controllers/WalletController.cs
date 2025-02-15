﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ark.API.Controllers;
using Ark.AppService;
using Ark.Entities.BO;
using Ark.Entities.DTO;
using Ark.ExternalUtilities;
using Ark.ExternalUtilities.Models;
using Info.Blockchain.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [HttpGet("Address/Btc/New")]
        public async Task<ActionResult> NewBtcAddressAsync()
        {
            WalletAddressResponseBO _apiResponse = new WalletAddressResponseBO();

            try
            {
                // GET SESSIONS
                SessionController sessionController = new SessionController();
                Blockchain blockchain = new Blockchain();
                UserAppService userAppService = new UserAppService();
                UserWalletAddressAppService userWalletAddressAppService = new UserWalletAddressAppService();

                TblUserAuth userAuth = sessionController.GetSession(HttpContext.Session);
                TblUserInfo userInfo = userAppService.Get(userAuth);
                List<TblUserWalletAddress> userWalletAddresses = userWalletAddressAppService.GetAll(userAuth);

                if (userWalletAddresses.Count != 0)
                {
                    _apiResponse.Address = userWalletAddresses.Find(i => i.WalletType.Code == "BTC").Address;
                }
                else
                {
                    BlockchainResponse _br = await blockchain.NewPaymentAddress("").ConfigureAwait(true);
                    _apiResponse.Address = _br.Address;
                    _apiResponse.XpubKey = _br.XpubKey;

                    bool _x = await userWalletAddressAppService.Create(userAuth,"BTC",_br.Address).ConfigureAwait(true);
                }

                _apiResponse.UserAuth = userAuth;
                _apiResponse.UserInfo = userInfo;

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.Message;
                _apiResponse.Status = "Error";

            }

            return Ok(_apiResponse);
        }

        [HttpGet("Address/Eth/New")]
        public ActionResult NewEthAddress()
        {
            WalletAddressResponseBO _apiResponse = new WalletAddressResponseBO();

            try
            {
                // GET SESSIONS
                SessionController sessionController = new SessionController();
                Changelly changelly = new Changelly();
                UserAppService userAppService = new UserAppService();

                TblUserAuth userAuth = sessionController.GetSession(HttpContext.Session);
                TblUserInfo userInfo = userAppService.Get(userAuth);

                ChangellyResponse PaymentAddress = changelly.CreateTransaction("eth", "btc", 0.1m);

                _apiResponse.UserAuth = userAuth;
                _apiResponse.UserInfo = userInfo;
                _apiResponse.Address = PaymentAddress.result.payinAddress;
                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.Message;
                _apiResponse.Status = "Error";

            }

            return Ok(_apiResponse);
        }

        [HttpGet("Address/Usdt/New")]
        public ActionResult NewUsdtAddress()
        {
            WalletAddressResponseBO _apiResponse = new WalletAddressResponseBO();

            try
            {
                // GET SESSIONS
                SessionController sessionController = new SessionController();
                Changelly changelly = new Changelly();
                UserAppService userAppService = new UserAppService();

                TblUserAuth userAuth = sessionController.GetSession(HttpContext.Session);
                TblUserInfo userInfo = userAppService.Get(userAuth);

                ChangellyResponse PaymentAddress = changelly.CreateTransaction("usdt", "btc", 20m);

                _apiResponse.UserAuth = userAuth;
                _apiResponse.UserInfo = userInfo;
                _apiResponse.Address = PaymentAddress.result.payinAddress;
                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.Message;
                _apiResponse.Status = "Error";

            }

            return Ok(_apiResponse);
        }

        [HttpGet("Address/Transactions")]
        public async Task<ActionResult> GetTransactionsAsync(string currency)
        {
            WalletAddressResponseBO _apiResponse = new WalletAddressResponseBO();

            try
            {
                // GET SESSIONS
                SessionController sessionController = new SessionController();
                Blockchain blockchain = new Blockchain();
                UserAppService userAppService = new UserAppService();
                UserWalletAddressAppService userWalletAddressAppService = new UserWalletAddressAppService();

                TblUserAuth userAuth = sessionController.GetSession(HttpContext.Session);
                TblUserInfo userInfo = userAppService.Get(userAuth);

                List<TblUserWalletAddress> userWalletAddresses = userWalletAddressAppService.GetAll(userAuth);

                BlockchainTx _br = await blockchain.GetAddressTransactions(userWalletAddresses.Find(i => i.WalletType.Code == currency).Address).ConfigureAwait(true);

                _apiResponse.UserAuth = userAuth;
                _apiResponse.UserInfo = userInfo;
                _apiResponse.AddressTransactions = JsonConvert.SerializeObject(_br);
                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.Message;
                _apiResponse.Status = "Error";

            }

            return Ok(_apiResponse);
        }
        
        [HttpPost("Send")]
        public ActionResult Send([FromBody] WalletTransactionBO walletTransaction)
        {
            ApiResponseBO _apiResponse = new ApiResponseBO();

            if (ModelState.IsValid)
            {
                try
                {
                    // GET SESSIONS
                    SessionController sessionController = new SessionController();
                    Blockchain blockchain = new Blockchain();

                    PaymentResponse _res = blockchain.Send(walletTransaction.To, (decimal)walletTransaction.Amount, 0m);
                    
                    _apiResponse.HttpStatusCode = "200";
                    _apiResponse.Status = _res.Message;
                }
                catch (Exception ex)
                {
                    _apiResponse.HttpStatusCode = "500";
                    _apiResponse.Message = ex.Message;
                    _apiResponse.Status = "Error";

                }
            }
            else
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = "Required data is missing";
                _apiResponse.Status = "Error";
            }

           

            return Ok(_apiResponse);

        }

    }
}