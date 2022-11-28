using System.ComponentModel.DataAnnotations;


namespace ReajusteSalarial.Models
{
    public class Employees : IEmployees
    {
        public Employees() { }
        public Employees(string nameEmployees, string positionEmployees, double salaryEmployees, int HiringYear) 
        {
            this.nameEmployees = nameEmployees;
            this.positionEmployees = positionEmployees;
            this.salaryEmployees = salaryEmployees;
            this.HiringYear = HiringYear;
        }

        public string nameEmployees { get; set; }
        public string positionEmployees { get; set; }
        public double salaryEmployees { get; set; }
        public int HiringYear { get; set; }

    }

}
