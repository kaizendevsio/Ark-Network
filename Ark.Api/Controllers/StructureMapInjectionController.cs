using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ark.API.Controllers;
using Ark.AppService;
using Ark.Entities.BO;
using Ark.Entities.DTO;
using Newtonsoft.Json;

namespace Ark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StructureMapInjectionController : ControllerBase
    {
        public readonly string Env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        [HttpPost("Parse")]
        public ActionResult Create([FromBody] StructureMapInjection structureMap)
        {
            UserAppService userAppService = new UserAppService();
            ApiResponseBO _apiResponse = new ApiResponseBO();
            SessionController sessionController = new SessionController();

            try
            {
                string appUrl = sessionController.ApiUriInit(Env).AbsoluteUri;
                userAppService.StructureMapTesting(structureMap,appUrl);

                _apiResponse.HttpStatusCode = "200";
                _apiResponse.Message = "User successfully created";
                _apiResponse.Status = "Success";

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.HttpStatusCode = "500";
                _apiResponse.Message = ex.InnerException.Message;
                _apiResponse.Status = "Error";
                return Ok(_apiResponse);
            }

        }
    }

}
