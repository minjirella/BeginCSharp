using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class AlbumData : EntityData<Album>
    {
        public Album GetByPK(int albumId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Albums.FirstOrDefault(x => x.AlbumId == albumId);
            }
        }

        public void DeleteByPK(int albumId)
        {
            Album entity = GetByPK(albumId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Album> Search(string albumName, int minArtistId, int maxArtistId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                IQueryable<Album> query = from x in context.Albums
                            select x;

                // lazy execution

                if (albumName != null)
                    query = query.Where(x => x.Title.Contains(albumName));

                if (minArtistId != 0)
                    query = query.Where(x => x.ArtistId >= minArtistId);

                if (maxArtistId != 0)
                    query = query.Where(x => x.ArtistId <= maxArtistId);

                return query.ToList();
            }

        }

        public List<Album> Search(string albumTitle, int? artistId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                //Dictionary를 써서 만들기
                Dictionary<int, string> artistNames = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);

                IQueryable<Album> query = from x in context.Albums
                                          select x;

                // lazy execution
                //if(string.IsNullOrEmpty(albumName) == false)
                if (albumTitle != null)
                    query = query.Where(x => x.Title.Contains(albumTitle));
                if (artistId.HasValue)
                    query = query.Where(x => x.ArtistId == artistId);

                var albums = query.ToList();

                foreach (var album in albums)
                {
                    //album.ArtistName = artists.Find(x=>x.ArtistId == album.ArtistId).Name;
                    // ->dict
                    album.ArtistName = artistNames[album.ArtistId];
                }

                return albums;
            }

        }
    }
}
