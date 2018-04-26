using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class songs
    {
      public string Songname { get; set; }

        public songs()
        {

        }

      public songs(string song_name)
      {
         this.Songname = song_name;
      }
      public static List<songs> list_of_songs()
      {

         return new List<songs>
         {

            new songs(
               song_name: "Hollaback girl"
            ),
            
            new songs(
               song_name: "All the stars"
            ),

             new songs(
               song_name: "Despacito"
            ),

             new songs(
               song_name: "Shape of you"
            ),

            new songs(
               song_name: "The Weekend"
            ),

             new songs(
               song_name: "Bodak Yellow"
            ),





         };



      }



      }
}
