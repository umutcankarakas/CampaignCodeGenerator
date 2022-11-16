using CampaignCodeGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CampaignCodeGenerator.Controllers
{
    [Route("[controller]")]
    public class CodeGeneratorController : Controller
    {
        [Route("GetList")]
        [HttpGet]
        public IEnumerable<String> GetList(int Count)
        {
            List<String> Coupons = new List<String>();
            return Coupons;
        }

        [Route("GetListWithId")]
        [HttpGet]
        public IEnumerable<CampaignCodeModel> GetListWithId(int Count)
        {
            List<CampaignCodeModel> Coupons = new List<CampaignCodeModel>();
            return Coupons;
        }

        [Route("GetSingleCode")]
        [HttpGet]
        public String GetSingleCode(int Id)
        {
            return "";
        }
    }
}
