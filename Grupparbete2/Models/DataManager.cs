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
            customer.Id = ++Customer.IdCount;

        }

        public static Customer[] GetAllCustomers()
        {
            return Customers.ToArray();
        }

        public static void Update(Customer customer)
        {
            //Hämta kund med rätt ID och uppdatera kontakten
            var temp = GetCustomerById(customer.Id);
            temp.CompanyName = customer.CompanyName;
            temp.Adress = customer.Adress;
            temp.EmployeeCount = customer.EmployeeCount;

        }
        public static Customer GetCustomerById(int id)
        {
            var customer = Customers
                .SingleOrDefault(c => c.Id == id);
            return customer;
        }
    }
}
