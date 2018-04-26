using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Songs
    {
      public string Songname { get; set; }

        public songs()
        {

        }

      public Songs(string song_name)
      {
         this.Songname = song_name;
      }
      public static List<Songs> list_of_songs()
      {

         return new List<Songs>
         {

            new Songs(
               song_name: "Hollaback girl"
            ),
            
            new Songs(
               song_name: "All the stars"
            ),

             new Songs(
               song_name: "Despacito"
            ),

             new Songs(
               song_name: "Shape of you"
            ),

            new Songs(
               song_name: "The Weekend"
            ),

             new Songs(
               song_name: "Bodak Yellow"
            ),





         };



      }



      }
}
