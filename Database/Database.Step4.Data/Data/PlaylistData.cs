using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step4.Data
{
    public class PlaylistData
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

        public static int GetCount()
        {
            using (var context = CreateContext())
            {
                return context.Playlists.Count();
            }
        }

        public static List<Playlist> GetAll()
        {
            using (var context = CreateContext())
            {
                return context.Playlists.ToList();
            }
        }

        public static Playlist GetByPK(int playlistId)
        {
            using (var context = CreateContext())
            {
                return context.Playlists.FirstOrDefault(x => x.PlaylistId == playlistId);
            }
        }

        public static void Insert(Playlist playlist)
        {
            using (var context = CreateContext())
            {
                //context.Students.Add(student);
                context.Entry(playlist).State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public static void Update(Playlist playlist)
        {
            using (var context = CreateContext())
            {
                context.Entry(playlist).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public static void Delete(Playlist playlist)
        {
            using (var context = CreateContext())
            {
                context.Entry(playlist).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
