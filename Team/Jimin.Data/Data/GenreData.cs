using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Data
{
    public class GenreData
    {
        public int GetTrackCount(string keyword)
        {
            using (var context = new ChinookEntities())
            {
                var query =
                    from x in context.Tracks
                    where x.Genre.Name.Contains(keyword)
                    select x;

                //                return query.ToList();
                return query.Count();
            }
        }
    }
}
