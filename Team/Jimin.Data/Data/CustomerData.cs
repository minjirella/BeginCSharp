using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Data
{
    // DatabaseEE
    public class CustomerData
    {
        private static ChinookEntities CreateContext()
        {
            ChinookEntities context = new ChinookEntities();
            context.Database.Log = PrintToConsoleWindow;
            return context;
        }

        public static int GetCount()
        {
            using (var context = CreateContext())
            {
                return context.Customers.Count();
            }
        }

        public List<Customer> GetAll()
        {
            using (var context = CreateContext())
            {
                return context.Customers.ToList();
            }
        }

        public static Customer GetByPK(int customerId)
        {
            using (var context = CreateContext())
            {
                return context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
            }
        }

        public Customer GetCustomerByFirstName(string firstName)
        {
            using (var context = CreateContext())
            {
                return context.Customers.FirstOrDefault(x => x.FirstName.Contains(firstName));
            }
        }


        public Invoice GetInvoiceIdByFirstNameAndBillingDate(string firstName, DateTime invoiceDate)
        {
            using (var context = CreateContext())
            {
                Customer customer = GetCustomerByFirstName(firstName);
                var query = from x in context.Invoices
                            where customer.CustomerId.Equals(x.CustomerId)
                            && invoiceDate == x.InvoiceDate
                            select x;

                return query.FirstOrDefault();
            }
        }
        public List<Album> GetAlbumsByAlbumIds(List<int> albumIds)
        {
            using (var context = new ChinookEntities())
            {
                var query =
                    from x in context.Albums
                    where albumIds.Contains(x.AlbumId)
                    select x;

                return query.ToList();
            }
        }

        public static void Insert(Customer customer)
        {
            using (var context = CreateContext())
            {
                context.Entry(customer).State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public static void Update(Customer customer)
        {
            using (var context = CreateContext())
            {
                context.Entry(customer).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public static void Delete(Customer customer)
        {
            using (var context = CreateContext())
            {
                context.Entry(customer).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        private static void PrintToConsoleWindow(string log)
        {
            Console.WriteLine(log);
        }
    }
}
