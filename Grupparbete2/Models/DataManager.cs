using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grupparbete2.Models
{
    public class DataManager
    {
        static List<Customer> Customers = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public static Customer[] GetAllCustomers()
        {
            return Customers.ToArray();
        }
    }
}
