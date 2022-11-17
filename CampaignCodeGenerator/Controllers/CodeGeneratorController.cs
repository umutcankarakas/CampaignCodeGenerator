using CampaignCodeGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CampaignCodeGenerator.Helper;

namespace CampaignCodeGenerator.Controllers
{
    [Route("[controller]")]
    public class CodeGeneratorController : Controller
    {
        //This method is to create "CodeCount" number of campaign codes
        [Route("GetCodeList")]
        [HttpGet]
        public IEnumerable<String> GetCodeList(long CodeCount)
        {
            List<String> Codes = new List<String>();

            for(long CodeId = 1; CodeId <= CodeCount; CodeId++)
            {
                Codes.Add(CodeGenerationHelper.GenerateCode(CodeId));
            }

            return Codes;
        }

        //This method is to create "CodeCount" number of campaign codes and return them with their "Ids"...
        //...in case the user wants to keep track of the used codes in the future
        [Route("GetCodeListWithId")]
        [HttpGet]
        public IEnumerable<CampaignCodeModel> GetCodeListWithId(long CodeCount)
        {
            List<CampaignCodeModel> Codes = new List<CampaignCodeModel>();
            for (long CodeId = 1; CodeId <= CodeCount; CodeId++)
            {
                CampaignCodeModel newCode = new CampaignCodeModel();
                newCode.Id = CodeId;
                newCode.Code = CodeGenerationHelper.GenerateCode(CodeId);
                Codes.Add(newCode);
            }
            return Codes;
        }
    }
}
