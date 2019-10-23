using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   public class DB
    {
        private static lab6Entities myDb = new lab6Entities();
        public static IEnumerable<Product> GetProducts()
        {
            return myDb.Products.ToList();
        }
        public static IEnumerable<Customer> GetCustomers()
        {
            return myDb.Customers.ToList();
        }

        public static IEnumerable<Sale> getSaleList()
        {
            return myDb.Sales.ToList();
        }

        public static Product getProduct(int id)
        {
            return myDb.Products.Find(id);
        }
        public static String UpdateCustomer(int id)
        {
            String fName = "Amin";
            String lName = "Meslioui";
            Customer cus = myDb.Customers.Find(id);
            cus.CustomerFirstName = fName;
            cus.CustomerLastName = lName;
            return ("Customer: " + id + " has been updated" + " First name: " + cus.CustomerFirstName + " Last name:" + cus.CustomerLastName);

        }
        //I am not using a delete method because we should not delete but purge (save) old data.
    }
}
