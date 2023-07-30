namespace CompanyMVCApp.Models
{
    public class History
    {
        public int Id { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public string StoreCity { get; set; }
        public int companyID { get; set; }
    }
}
