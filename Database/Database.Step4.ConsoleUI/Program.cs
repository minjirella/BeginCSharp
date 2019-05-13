using Database.Step4.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Album a350 = AlbumData.GetByPK(350);
            //a350.Title = "ReReload";
            //a350.ArtistId = 50;
            //AlbumData.Update(a350);

            //Console.WriteLine(AlbumData.GetCount());
            //AlbumData.Delete(a350);
            //Console.WriteLine(AlbumData.GetCount());

            Album a350 = new Album();
            a350.ArtistId = 50;
            a350.Title = "Lulu Album";
            
            AlbumData.Insert(a350);

            Console.WriteLine(AlbumData.GetCount());
            Console.WriteLine($"{a350.Artist}");

        }


        private static void PrintToDebugWindow(string log)
        {
            Debug.WriteLine(log);
        }
    }
}
