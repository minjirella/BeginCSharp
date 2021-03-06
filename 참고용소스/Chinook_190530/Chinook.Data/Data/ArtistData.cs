﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class ArtistData : EntityData<Artist>
    {
        public Artist GetByPK(int artistId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Artists.FirstOrDefault(x => x.ArtistId == artistId);
            }
        }

        public void DeleteByPK(int artistId)
        {
            Artist entity = GetByPK(artistId);

            if (entity == null)
                return;

            Delete(entity);
        }
    }
}
