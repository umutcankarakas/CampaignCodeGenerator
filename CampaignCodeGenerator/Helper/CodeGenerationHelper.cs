using System;

namespace CampaignCodeGenerator.Helper
{
    public class CodeGenerationHelper
    {

        private static String charSet1 = "R79TXYZ79X";
        private static String charSet2 = "AC23DEFG23";
        private static String charSet3 = "H45KLMNP45";
        private static int m = 39293;
        private static int s = 75321908;

        public static String GenerateCode(int Id)
        {
            String code = "";
            String indexer = ((m * Id + s) % 100000000).ToString();
            if (indexer.Length < 8)
            {
                String tempCode = "";
                for (int i = 0; i < 8 - indexer.Length; i++)
                {
                    tempCode += "0";
                }
                tempCode += indexer;
                indexer = tempCode;
            }
            
            for (int i = 0; i < indexer.Length; i++)
            {
                if(i%3 == 0)
                {
                    code += charSet1[int.Parse(indexer[i].ToString())];
                }
                else if(i%3 == 1)
                {
                    code += charSet2[int.Parse(indexer[i].ToString())];
                }
                else if (i%3 == 2)
                {
                    code += charSet3[int.Parse(indexer[i].ToString())];
                }
            }
            return code;
        }
    }
}
