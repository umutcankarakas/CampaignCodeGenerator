using Microsoft.AspNetCore.Mvc;
using System;

namespace CampaignCodeGenerator.Controllers
{
    public class CodeVerificationController : Controller
    {
        [Route("VerifyCode")]
        [HttpGet]
        public bool VerifyCode(String Code)
        {
            
            return false;
        }
    }
}
