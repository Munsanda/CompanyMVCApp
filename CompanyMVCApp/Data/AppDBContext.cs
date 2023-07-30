using CompanyMVCApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CompanyMVCApp.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> optionsBuilder)
            : base(optionsBuilder)
        {
            LoadData();
        }

        public DbSet<CompanyMVCApp.Models.Company> Companies { get; set; }
        public DbSet<CompanyMVCApp.Models.Employees> Employees { get; set; }
        public DbSet<CompanyMVCApp.Models.History> Histories { get; set; }
        public DbSet<CompanyMVCApp.Models.Notes> Notes { get; set; }
        public DbSet<CompanyMVCApp.Models.Position> Postions { get; set; }

        public void LoadData()
        {
            List<Company> companiesList = new List<Company>
            {
                new Company { Id = 1, CompanyName = "Milk company", CompanyCity = "Cansas", CompanyState = "Kansas", CompanyPhoneNumber = "0978107234" },
                new Company { Id = 2, CompanyName = "Tech Solutions", CompanyCity = "New York", CompanyState = "New York", CompanyPhoneNumber = "0987654321" },
                new Company { Id = 3, CompanyName = "Food Industries", CompanyCity = "Chicago", CompanyState = "Illinois", CompanyPhoneNumber = "0123456789" },
                new Company { Id = 4, CompanyName = "Fashion House", CompanyCity = "Los Angeles", CompanyState = "California", CompanyPhoneNumber = "0934567890" },
                new Company { Id = 5, CompanyName = "Software Co.", CompanyCity = "Seattle", CompanyState = "Washington", CompanyPhoneNumber = "0876543210" },
                new Company { Id = 6, CompanyName = "Construction Inc.", CompanyCity = "Dallas", CompanyState = "Texas", CompanyPhoneNumber = "0765432109" },
                new Company { Id = 7, CompanyName = "Electronics Ltd.", CompanyCity = "San Francisco", CompanyState = "California", CompanyPhoneNumber = "0912345678" },
                new Company { Id = 8, CompanyName = "Marketing Agency", CompanyCity = "Miami", CompanyState = "Florida", CompanyPhoneNumber = "0890123456" },
                new Company { Id = 9, CompanyName = "Transport Services", CompanyCity = "Houston", CompanyState = "Texas", CompanyPhoneNumber = "0856789012" },
                new Company { Id = 10, CompanyName = "Pharmaceuticals", CompanyCity = "Boston", CompanyState = "Massachusetts", CompanyPhoneNumber = "0832109876" },
                new Company { Id = 11, CompanyName = "Furniture Store", CompanyCity = "Denver", CompanyState = "Colorado", CompanyPhoneNumber = "0876543210" },
                new Company { Id = 12, CompanyName = "Hospitality Group", CompanyCity = "Las Vegas", CompanyState = "Nevada", CompanyPhoneNumber = "0812345678" },
                new Company { Id = 13, CompanyName = "Automobiles Inc.", CompanyCity = "Detroit", CompanyState = "Michigan", CompanyPhoneNumber = "0890123456" },
                new Company { Id = 14, CompanyName = "Media Productions", CompanyCity = "Atlanta", CompanyState = "Georgia", CompanyPhoneNumber = "0845678901" },
                new Company { Id = 15, CompanyName = "Education Services", CompanyCity = "Philadelphia", CompanyState = "Pennsylvania", CompanyPhoneNumber = "0821098765" },
                new Company { Id = 16, CompanyName = "Insurance Agency", CompanyCity = "Phoenix", CompanyState = "Arizona", CompanyPhoneNumber = "0876543210" },
                new Company { Id = 17, CompanyName = "Real Estate Co.", CompanyCity = "San Diego", CompanyState = "California", CompanyPhoneNumber = "0812345678" },
                new Company { Id = 18, CompanyName = "Energy Solutions", CompanyCity = "Austin", CompanyState = "Texas", CompanyPhoneNumber = "0890123456" },
                new Company { Id = 19, CompanyName = "Fitness Center", CompanyCity = "Orlando", CompanyState = "Florida", CompanyPhoneNumber = "0867890123" },
                new Company { Id = 20, CompanyName = "Legal Services", CompanyCity = "Washington, D.C.", CompanyState = "Washington, D.C.", CompanyPhoneNumber = "0832109876" }
            };
            List<History> historyList = new List<History>
            {
                new History { Id = 1, OrderDate = DateTimeOffset.Parse("2023-07-23"), StoreCity = "New York", companyID = 1 },
                new History { Id = 2, OrderDate = DateTimeOffset.Parse("2023-07-22"), StoreCity = "Los Angeles", companyID = 3 },
                new History { Id = 3, OrderDate = DateTimeOffset.Parse("2023-07-21"), StoreCity = "Chicago", companyID = 2 },
                new History { Id = 4, OrderDate = DateTimeOffset.Parse("2023-07-20"), StoreCity = "Houston", companyID = 5 },
                // Add more History objects for other companies here
                new History { Id = 5, OrderDate = DateTimeOffset.Parse("2023-07-19"), StoreCity = "San Francisco", companyID = 6 },
                new History { Id = 6, OrderDate = DateTimeOffset.Parse("2023-07-18"), StoreCity = "Seattle", companyID = 4 },
                new History { Id = 7, OrderDate = DateTimeOffset.Parse("2023-07-17"), StoreCity = "Miami", companyID = 7 },
                new History { Id = 8, OrderDate = DateTimeOffset.Parse("2023-07-16"), StoreCity = "Boston", companyID = 8 },
                // Add more History objects for other companies here
                new History { Id = 9, OrderDate = DateTimeOffset.Parse("2023-07-15"), StoreCity = "Dallas", companyID = 9 },
                new History { Id = 10, OrderDate = DateTimeOffset.Parse("2023-07-14"), StoreCity = "Atlanta", companyID = 10 },
                new History { Id = 11, OrderDate = DateTimeOffset.Parse("2023-07-13"), StoreCity = "Denver", companyID = 11 },
                new History { Id = 12, OrderDate = DateTimeOffset.Parse("2023-07-12"), StoreCity = "Phoenix", companyID = 12 },
                // Add more History objects for other companies here
                new History { Id = 13, OrderDate = DateTimeOffset.Parse("2023-07-11"), StoreCity = "Philadelphia", companyID = 13 },
                new History { Id = 14, OrderDate = DateTimeOffset.Parse("2023-07-10"), StoreCity = "Washington D.C.", companyID = 14 },
                new History { Id = 15, OrderDate = DateTimeOffset.Parse("2023-07-09"), StoreCity = "San Diego", companyID = 15 },
                new History { Id = 16, OrderDate = DateTimeOffset.Parse("2023-07-08"), StoreCity = "Minneapolis", companyID = 16 },
                // Add more History objects for other companies here
                new History { Id = 17, OrderDate = DateTimeOffset.Parse("2023-07-07"), StoreCity = "Portland", companyID = 17 },
                new History { Id = 18, OrderDate = DateTimeOffset.Parse("2023-07-06"), StoreCity = "Detroit", companyID = 18 },
                new History { Id = 19, OrderDate = DateTimeOffset.Parse("2023-07-05"), StoreCity = "Orlando", companyID = 19 },
                new History { Id = 20, OrderDate = DateTimeOffset.Parse("2023-07-04"), StoreCity = "Charlotte", companyID = 20 }

            };
            List<Notes> notesList = new List<Notes>();
            List<Employees> employeesList = new List<Employees>
            {
                new Employees
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    title = Title.Mr,
                    DOB = new DateTimeOffset(1990, 5, 15, 0, 0, 0, TimeSpan.Zero),
                    companyID = 1,
                    PositionID = 1,
                },
                new Employees
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    title = Title.Ms,
                    DOB = new DateTimeOffset(1985, 8, 25, 0, 0, 0, TimeSpan.Zero),
                    companyID = 4,
                    PositionID = 2,
                },
                new Employees
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    title = Title.Dr,
                    DOB = new DateTimeOffset(1978, 11, 3, 0, 0, 0, TimeSpan.Zero),
                    companyID = 3,
                    PositionID = 3,
                },
                new Employees
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Brown",
                    title = Title.Mrs,
                    DOB = new DateTimeOffset(1992, 2, 9, 0, 0, 0, TimeSpan.Zero),
                    companyID = 2,
                    PositionID = 2,
                },
                new Employees
                {
                    Id = 5,
                    FirstName = "David",
                    LastName = "Lee",
                    title = Title.Mr,
                    DOB = new DateTimeOffset(1987, 7, 18, 0, 0, 0, TimeSpan.Zero),
                    companyID = 5,
                    PositionID = 2,
                },
                // Add more employees as needed
            };
            List<Position> positionsList = new List<Position>
            {
                new Position
                {
                    Id = 101,
                    Title = "Software Engineer",
                    EmployeeID = 1
                },
                new Position
                {
                    Id = 102,
                    Title = "Project Manager",
                    EmployeeID = 2
                },
                new Position
                {
                    Id = 103,
                    Title = "Data Scientist",
                    EmployeeID = 3
                },
                new Position
                {
                    Id = 104,
                    Title = "Sales Representative",
                    EmployeeID = 4
                },
                new Position
                {
                    Id = 105,
                    Title = "HR Manager",
                    EmployeeID = 5
                },
                // Add more positions as needed
            };


            Companies.AddRange(companiesList);
            Histories.AddRange(historyList);
            Notes.AddRange(notesList);
            Employees.AddRange(employeesList);
            Postions.AddRange(positionsList);
            
        }

        public List<Company> GetCompanies()
        {
            return Companies.Local.ToList<Company>();
        }
        public List<History> GetHistoryList(int id)
        {
            return Histories.Local.Where(h => h.companyID == id).ToList<History>();
        }

        public List<Employees> GetEmployeesList(int id)
        {
            return Employees.Local.Where(e => e.companyID == id).ToList<Employees>();
        }

        public List<Notes> GetNotesList(int id)
        {
            return Notes.Local.Where(n => n.companyID == id).ToList<Notes>();  
        }

        public List<Employees> GetEmployees()
        {
            return Employees.Local.ToList<Employees>();
        }

        public Company GetCompany(int id)
        {
            List<History> companyHistory = this.GetHistoryList(id);
            List<Employees> companyEmployees = this.GetEmployeesList(id);
            List<Notes> companyNotes = this.GetNotesList(id);

            if (companyHistory == null)
                companyHistory = new List<History>();

            List<Notes> notes;

            return Companies
                .Include(h => companyHistory)
                .ThenInclude(e => companyEmployees)
                .ThenInclude(n => companyNotes)
                .FirstOrDefault(x => x.Id == id);
        }


    }
}
