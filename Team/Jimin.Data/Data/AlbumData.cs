using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Data
{
    public class AlbumData
    {
        public List<Album> GetAlbumsByGenre(string keyword)
        {
            using (var context = new ChinookEntities())
            {
                var albumQuery =
                    from x in context.Tracks
                    where x.Genre.Name.Contains(keyword)
                    select (int)x.AlbumId;

                List<int> albumIds = albumQuery.Distinct().ToList();

                var query = from x in context.Albums
                            where albumIds.Contains(x.AlbumId)
                            select x;
                return query.ToList();
            }
        }
    }
}
