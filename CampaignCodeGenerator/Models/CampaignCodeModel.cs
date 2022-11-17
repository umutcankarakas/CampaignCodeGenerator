namespace CampaignCodeGenerator.Models
{
    //If the user wants to get the codes with their Ids, this model will be used.
    public class CampaignCodeModel
    {
        public long Id { get; set; }
        public string Code { get; set; }
    }
}
