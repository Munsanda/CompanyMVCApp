using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMVCApp.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public int EmployeeID { get; set; }
        [NotMapped]
        public Employees Employee { get; set; }
        public int companyID { get; set; }
    }
}
