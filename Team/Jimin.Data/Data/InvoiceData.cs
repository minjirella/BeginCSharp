using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Data
{
    public class InvoiceData
    {
        private static ChinookEntities CreateContext()
        {
            ChinookEntities context = new ChinookEntities();
            context.Database.Log = PrintToConsoleWindow;
            return context;
        }

        private static void PrintToConsoleWindow(string log)
        {
            Console.WriteLine(log);
        }

        public static Invoice GetTotalPrice(int invoiceId)
        {
            using (var context = CreateContext())
            {
                return context.Invoices.FirstOrDefault(x => x.InvoiceId == invoiceId);
            }

        }

        // Database_bae
        public double GetCustomerTotalPrice(string LastName)
        {
            using (var context = CreateContext())
            {
                var query = from x in context.Invoices
                            where x.Customer.LastName.Equals(LastName)
                            select x.Total;

                return (double)query.Sum();
            }
        }

        //DataBaseEE
        public void Update(Invoice invoice)
        {
            using (var context = CreateContext())
            {
                context.Entry(invoice).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public static void Delete(Invoice invoice)
        {
            using (var context = CreateContext())
            {
                context.Entry(invoice).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        
        public int GetCountByBillingCountry(String keyword)
        {
            using (var context = new ChinookEntities())
            {
                var query =
                    from x in context.Invoices
                    where x.BillingCountry.Contains(keyword)
                    select x;
                //                return query.ToList();
                return query.Count();
            }
        }

        public List<int> GetAlbumIdByBillingCountry(String keyword)
        {
            using (var context = new ChinookEntities())
            {
                var query =
                    from x in context.Invoices
                    where x.BillingCountry.Contains(keyword)
                    select x.InvoiceId;

                List<int> invoiceIds = query.ToList();
                query =
                    from x in context.InvoiceLines
                    where invoiceIds.Contains(x.InvoiceId)
                    select x.TrackId;
                List<int> trackIds = query.ToList();
                query =
                    from x in context.Tracks
                    where trackIds.Contains(x.TrackId)
                    select (int)x.AlbumId;

                return query.Distinct().ToList();
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
    }
}
