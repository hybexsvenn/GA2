using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grupparbete2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        static public int IdCount { get; set; }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public int EmployeeCount { get; set; }



    }
}
