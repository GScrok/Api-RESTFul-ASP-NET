namespace RESTFulAPI.Configurations
{
    public class TokenConfiguration
    {
        public string Audience {  get; set; }
        public string Issuer {  get; set; }
        public string Secret {  get; set; }
        public int Minutes {  get; set; }
        public int DaysToExpires {  get; set; }
    }
}
