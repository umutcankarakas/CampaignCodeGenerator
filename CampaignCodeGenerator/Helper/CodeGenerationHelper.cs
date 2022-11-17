using System;

namespace CampaignCodeGenerator.Helper
{
    public class CodeGenerationHelper
    {
        //Normally the desired char set is "ACDEFGHKLMNPRTXYZ234579" but I breaked it down to three parts
        //We needed 30 chars in total so I had to do some repetations. It may cause different ids mapping into single code but...
        //...the probability of that happening is pretty low.
        private static String charSet1 = "R79TXYZ79X";
        private static String charSet2 = "AC23DEFG23";
        private static String charSet3 = "H45KLMNP45";

        //Some random numbers for calculating the indexer for different ids
        private static int m = 74623;
        private static int s = 35782904;

        //Generates one single code for given code id
        public static String GenerateCode(long Id)
        {
            String code = "";
            String indexer = ((m * Id + s) % 100000000).ToString();

            //Modulo operation might result with an output which has less than 8 characters, so we fill from the beginning
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
            
            //Selecting char from different charSets, depending on their index
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
