using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Models
{
    public class NewEmployees : Employees
    {
        public List<Employees> lista { get; set; }
        public NewEmployees() 
        {
            this.lista = new List<Employees>();
        }
    }
}
