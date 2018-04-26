using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    public class Songs
    {
      public string Songname { get; set; }
        

      public Songs(string song_name)
      {
         this.Songname = song_name;
      }
      public static List<Songs> list_of_songs()
      {

         return new List<Songs>
         {

            new Songs(
               song_name: "Hollaback Girl"
            ),
            
            new Songs(
               song_name: "All The Stars"
            ),

             new Songs(
               song_name: "Despacito"
            ),

             new Songs(
               song_name: "Shape of You"
            ),

            new Songs(
               song_name: "The Weekend"
            ),

             new Songs(
               song_name: "Bodak Yellow"
            ),

             new Songs(
               song_name: "God's Plan"
            ),

             new Songs(
               song_name: "One Love"
            ),

             new Songs(
               song_name: "Walk It Talk It"
            ),

             new Songs(
               song_name: "In My Blood"
            ),

             new Songs(
               song_name: "Meant To Be"
            ),





         };



      }



      }
}
