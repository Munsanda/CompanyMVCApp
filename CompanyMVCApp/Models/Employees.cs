using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMVCApp.Models
{
    public enum Title
    {
        Mr,
        Ms,
        Mrs,
        Dr,
        Proff
    };
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Title title { get; set; }
        public DateTimeOffset DOB { get; set; }
        public int companyID { get; set; }

        [ForeignKey(nameof(Employees))]
        public int PositionID { get; set; }
        [NotMapped]
        public Position? EmployeePosition { get; set; }
    }
   
}
