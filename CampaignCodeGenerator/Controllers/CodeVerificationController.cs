using Microsoft.AspNetCore.Mvc;
using System;
using CampaignCodeGenerator.Helper;

namespace CampaignCodeGenerator.Controllers
{
    [Route("[controller]")]
    public class CodeVerificationController : Controller
    {
        [Route("VerifyCode")]
        [HttpGet]
        public bool VerifyCode(String Code)
        {
            return CodeVerificationHelper.VerifyCode(Code);
        }

        [Route("GetCodeIdFromCode")]
        [HttpGet]
        public int GetCodeIdFromCode(String Code, int CodeCount)
        {
            return CodeVerificationHelper.GetCodeIdFromCode(Code, CodeCount);
        }
    }
}
