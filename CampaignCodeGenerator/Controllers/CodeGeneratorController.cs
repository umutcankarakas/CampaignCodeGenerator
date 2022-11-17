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
        [Route("GetCodeList")]
        [HttpGet]
        public IEnumerable<String> GetCodeList(int CodeCount)
        {
            List<String> Codes = new List<String>();

            for(int CodeId = 1; CodeId <= CodeCount; CodeId++)
            {
                Codes.Add(CodeGenerationHelper.GenerateCode(CodeId));
            }

            return Codes;
        }

        [Route("GetListWithId")]
        [HttpGet]
        public IEnumerable<CampaignCodeModel> GetCodeListWithId(int CodeCount)
        {
            List<CampaignCodeModel> Codes = new List<CampaignCodeModel>();
            for (int CodeId = 1; CodeId <= CodeCount; CodeId++)
            {
                CampaignCodeModel newCode = new CampaignCodeModel();
                newCode.Id = CodeId;
                newCode.Code = CodeGenerationHelper.GenerateCode(CodeId);
                Codes.Add(newCode);
            }
            return Codes;
        }

        [Route("GetSingleCode")]
        [HttpGet]
        public String GetSingleCode(int CodeId)
        {
            return CodeGenerationHelper.GenerateCode(CodeId); ;
        }
    }
}
