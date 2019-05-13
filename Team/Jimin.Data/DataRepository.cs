using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team;
using Team.Data;

namespace Team.Data
{
    public class DataRepository
    {
        //static DataRepository()
        //{
        //    Genre = new GenreData();
        //    Track = new TrackData();
        //    Album = new AlbumData();
        //}

        //public static GenreData Genre { get; }
        //public static TrackData Track { get; }
        //public static AlbumData Album { get; }

        static DataRepository()
        {
            InvoiceLine = new InvoiceLineData();
            Track = new TrackData();
            Invoice = new InvoiceData();
            Genre = new GenreData();
            Album = new AlbumData();
            Customer = new CustomerData();
        }


        public static InvoiceLineData InvoiceLine { get;  }
        public static TrackData Track { get; }
        public static InvoiceData Invoice { get; }
        public static GenreData Genre { get; }
        public static AlbumData Album { get; }
        public static CustomerData Customer { get; }

    }
}
