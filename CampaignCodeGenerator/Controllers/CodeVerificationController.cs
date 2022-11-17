using Microsoft.AspNetCore.Mvc;
using System;
using CampaignCodeGenerator.Helper;

namespace CampaignCodeGenerator.Controllers
{
    [Route("[controller]")]
    public class CodeVerificationController : Controller
    {
        //Checks if the code is valid and exists in a given range
        [Route("CheckCodeValidity")]
        [HttpGet]
        public bool CheckCodeValidity(String Code)
        {
            return CodeVerificationHelper.GetCodeValidity(Code);
        }

        //Gets the code id back from the code, and if the code doesnt exists, returns -1.
        [Route("GetCodeIdFromCode")]
        [HttpGet]
        public long GetCodeIdFromCode(String Code, long CodeCount)
        {
            return CodeVerificationHelper.GetCodeIdFromCode(Code, CodeCount);
        }

        //Checks if the code is valid and exists in a given range.
        [Route("VerifyCode")]
        [HttpGet]
        public bool VerifyCode(String Code, long CodeCount)
        {
            return CodeVerificationHelper.VerifyCode(Code, CodeCount);
        }
    }
}
