using System;

namespace CampaignCodeGenerator.Helper
{
    public class CodeVerificationHelper
    {
        private static String charSet1 = "R79TXYZ79X";
        private static String charSet2 = "AC23DEFG23";
        private static String charSet3 = "H45KLMNP45";
        private static int m = 39293;
        private static int s = 75321908;

        //Checks if the code is valid
        public static bool GetCodeValidity(String Code)
        {
            if (Code.Length != 8) return false;
            for (int i = 0; i < Code.Length; i++)
            {
                if (i % 3 == 0 && !charSet1.Contains(Code[i])) return false;
                else if (i % 3 == 1 && !charSet2.Contains(Code[i])) return false;
                else if (i % 3 == 2 && !charSet3.Contains(Code[i])) return false;
            }
            return true;
        }

        //Checks if the code is exists in a given range
        public static long GetCodeIdFromCode(String Code, long CodeCount) 
        {
            for (long CodeId = 1; CodeId <= CodeCount; CodeId++)
            {
                if(CodeGenerationHelper.GenerateCode(CodeId) == Code)
                {
                    return CodeId;
                }
            }
            return -1;
        }

        //Checks if the code is valid and exists in a given range
        public static bool VerifyCode(String Code, long CodeCount)
        {
            return GetCodeValidity(Code) && (GetCodeIdFromCode(Code, CodeCount) != -1);
        }
    }
}
