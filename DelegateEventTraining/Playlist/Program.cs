using PlaylistLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist("HardWired", "Metallica",100);
            Console.WriteLine($"{playlist.TrackName} - {playlist.ArtistName}");


            //의도 : 사용자에게 커맨드를 입력받아, 좋아요 수를 증감하는 이벤트작성.(아래로직을 이벤트로 처리해주고픔)
            Console.WriteLine("좋아요 : y, 싫어요 : n ");
            string answer = Console.ReadLine();

            playlist.HitChanged += Playlist_HitChanged;
            if (answer == "y") playlist.IncreaseHit();
            else if (answer == "n") playlist.DecreaseHit();
        }

        private static void Playlist_HitChanged(object sender, Playlist.HitChangedEventArgs e)
        {
            Console.WriteLine($"{e.OldHit} -> {e.NewHit}");
        }

        
    }
}
