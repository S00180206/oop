using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Exam
{
    class Program
    {
        static void Main(string[] args)
        {//input
            Song song1 = new Song("ED SHEERAN", "beautiful people", 3.15);
            Song song2 = new Song("REGARD", "ride it", 3.27);
            Song song3 = new Song("TONES & I", "dance monkey", 4.20);
            Song song4 = new Song("POST MALONE", "circles", 3.25);
            Song song5 = new Song("ED SHEERAN", "south of the border", 4.26);

            List<Song> Playlist = new List<Song>();
            Playlist.Add(song1);
            Playlist.Add(song2);
            Playlist.Add(song3);
            Playlist.Add(song4);
            Playlist.Add(song5);


            Display(Playlist);
            DisplayPlaylistDetails(Playlist);






            public static void Display(List<Song> songs)//display the list of songs
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Song1", "Song2", "Song3", "Song4", "Song5");

                //loop for players and scores

                foreach (Song song in songs)
                {
                    Console.Write("{0,-10}", song.);
                }

                Console.WriteLine();//new line to make it more tidy
            }

            private static void DisplayPlaylistDetails(List<Song> songs)
            {
                Console.WriteLine($"{"Artist"}\t{"Title"}\t{"Duration"}\t{"genre"}");
                foreach (Song player in songs)
                {
                    Console.WriteLine(song);
                }
            }
        }
    }
}
