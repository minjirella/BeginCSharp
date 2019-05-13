using Team.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");

            //Console.WriteLine($"{list.Count}");

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"result : {item.InvoiceLineId} \t {item.InvoiceId}\t {item.TrackId}\t {item.UnitPrice}\t {item.Quantity}");
            //}

            const int InvoiceId = 11;
            List<InvoiceLine> list = InvoiceLineData.GetByInvoiceId(InvoiceId);
            List<Track> tracklist = TrackData.GetTrackByInvoiceId(InvoiceId);

            foreach (var track in tracklist)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.TrackId} \t {track.Name}");

                }
            }

        }
    }
}
