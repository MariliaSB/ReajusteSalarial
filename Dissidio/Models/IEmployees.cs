using System.ComponentModel.DataAnnotations;

namespace ReajusteSalarial.Models
{
    public interface IEmployees
    {
        public string nameEmployees { get; set; }
        public string positionEmployees { get; set; }
        public double salaryEmployees { get; set; }
        public int HiringYear { get; set; }
    }
}