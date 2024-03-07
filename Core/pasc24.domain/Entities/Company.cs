namespace pasc24.domain.Entities
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public required string CompanyName { get; set; }
        public required string CompanyNIF { get; set; }
        public string ? CompanyLogo1 { get; set; }
        public string ? CompanyLogo2 { get; set; }
        public string ? CompanyStamp { get; set; }
        public string ? CompanyPaidStamp { get; set; }
        public string ? AdminSignature { get; set; }
        public required bool IsAcive { get; set; }
        
    }

}