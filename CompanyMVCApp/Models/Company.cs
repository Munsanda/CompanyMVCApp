namespace CompanyMVCApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyPhoneNumber { get; set; }

        public ICollection<Employees> Employees { get; set; }
        public ICollection<History> History { get; set; }
        public ICollection<Notes> Notes { get; set; }
    }
}
