namespace NetCoreJwtRsaDemo.Configuration
{
    public class ExternalClientJsonConfiguration
    {
        public static string SectionName => "ExternalClientServer";
        public string ReferralUrl { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string ReferralId { get; set; }
        public string RsaPrivateKey { get; set; }
        public string RsaPublicKey { get; set; }
    }
}
