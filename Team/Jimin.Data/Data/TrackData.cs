using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Data
{
    public class TrackData
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

        /* TODO : 지금의 결과는 InvoiceId를 입력받아 Track명을 출력하는것이다
         *        더 해보고자 하는 기능 : InvoiceId를 입력받아
         *        + Track에 해당하는 Artist이름 출력 ( Track -> Album -> Artist )
         *        여기서 어떻게 더 해야할지 Araboza
         */
        public static List<Track> GetTrackByInvoiceId(int invoiceId)
        {
            using (var context = CreateContext())
            {
                var InvoiceTrackList = (
                    from x in context.InvoiceLines
                    where x.InvoiceId == invoiceId
                    select x.Track).ToList();

                //List<Album> albums = context.Albums.ToList();

                foreach (Track track in InvoiceTrackList)
                {
                    //Album album = albums.Find(x => x.AlbumId == track.AlbumId);
                    Album album = context.Albums.FirstOrDefault(x => x.AlbumId == track.AlbumId);
                        //albums.Find(x => x.AlbumId == track.AlbumId);

                    if (album != null)
                        track.AlbumTitle = album.Title;
                }

                return InvoiceTrackList;
            }
        }

        public List<Track> GetTracksByAlbum(string keyword)
        {
            using (var context = CreateContext())
            {
                var query = from y in context.Tracks
                            where y.Album.Title.Contains(keyword)
                            select y;

                return query.ToList();
            }
        }

        public List<String> GetTracks(string LastName)
        {
            using (var context = CreateContext())
            {
                List<string> TrackName = new List<string>();

                var query = from x in context.Customers
                            where x.LastName.Equals(LastName)
                            select x.CustomerId;

                int customerId = query.FirstOrDefault();

                var query1 = from x in context.InvoiceLines
                             where x.Invoice.CustomerId.Equals(customerId)
                             select x.TrackId;

                List<int> trackId = query1.ToList(); // 중복처리

                foreach (var item in trackId) //for(int i = 0; i < trackId.Count; i++)
                {
                    var query3 = from x in context.Tracks
                                 where x.TrackId.Equals(item)
                                 select x.Name;

                    TrackName.Add(query3.First());
                }

                return TrackName;
            }
        }
    }
}
