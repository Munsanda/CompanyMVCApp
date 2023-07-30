using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMVCApp.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int EmployeeID { get; set; }
        [NotMapped]
        public Employees Employee { get; set; }
    }
}
