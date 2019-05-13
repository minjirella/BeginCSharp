using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Data
{
    public class InvoiceLineData
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

        public static List<InvoiceLine> GetByInvoiceId(int invoiceId)
        {
            using (var context = CreateContext())
            {
                var InvoiceList = context.InvoiceLines
                    .Where(i => i.InvoiceId == invoiceId)
                    .ToList();

                return InvoiceList;
            }
        }
    }
}
