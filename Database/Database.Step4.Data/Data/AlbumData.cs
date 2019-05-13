using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step4.Data
{
    public class AlbumData
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
                return context.Albums.Count();
            }
        }

        public static List<Album> GetAll()
        {
            using (var context = CreateContext())
            {
                return context.Albums.ToList();
            }
        }

        public static Album GetByPK(int albumId)
        {
            using (var context = CreateContext())
            {
                return context.Albums.FirstOrDefault(x => x.AlbumId == albumId);
            }
        }

        public static void Insert(Album album)
        {
            using (var context = CreateContext())
            {
                //context.Students.Add(student);
                context.Entry(album).State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public static void Update(Album album)
        {
            using (var context = CreateContext())
            {
                context.Entry(album).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public static void Delete(Album album)
        {
            using (var context = CreateContext())
            {
                context.Entry(album).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
