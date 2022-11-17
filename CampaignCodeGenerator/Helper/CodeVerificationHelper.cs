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
        public static bool VerifyCode(String Code)
        {
            for (int i = 0; i < Code.Length; i++)
            {
                if (i % 3 == 0 && !charSet1.Contains(Code[i])) return false;
                else if (i % 3 == 1 && !charSet2.Contains(Code[i])) return false;
                else if (i % 3 == 2 && !charSet3.Contains(Code[i])) return false;
            }
            return true;
        }

        public static int GetCodeIdFromCode(String Code, int CodeCount) {
            for (int CodeId = 1; CodeId <= CodeCount; CodeId++)
            {
                if(CodeGenerationHelper.GenerateCode(CodeId) == Code)
                {
                    return CodeId;
                }
            }
            return -1;
        }

    }
}
