using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Exam
{
    public class Song :IComparable//
    {
        //setup
        string Title, Artist;
        double Duration;
        Genre genre;

        enum Genre { Rock, Pop, Dance, Other };//enum list of genre of music

        public Song (string title, string artist, double duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }



        public override string ToString()
        {
            return $"{Artist}\t{Title}\t{Duration}\t{genre}";
        }

        public int CompareTo(object obj)
        {
            Song objectThatIAmComparingTo = (Song)obj;// sothing to compare our object to

            //compareable by order of artist
            int returnValue = this.Artist.CompareTo(objectThatIAmComparingTo.Artist);

            //return
            return returnValue;
        }

       


    }
}
