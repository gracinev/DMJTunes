using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Moive_Databinding_G1
{
    public class Artist
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AlbumName { get; set; }
        public DateTime Date { get; set; }
        public Image Image { get; set; }

        public Artist()
        {
            //Test comment
        }
        public Artist(string Name, string Description, string AlbumName, DateTime Date, string imageFilename)
        {
            this.Name = Name;
            this.Description = Description;
            this.AlbumName = AlbumName;
            this.Date = Date;
            Image = new Image();
            Image.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{imageFilename}", UriKind.RelativeOrAbsolute));
        }
        public string YearOnly
        {
            get
            {
                return $"({Date.Year})";
            }
        }
        public static List<Artist> AllMovies()
        {
            Artist m = new Artist(Name: "name", AlbumName:"name2", Date: new DateTime(1, 1, 2018), Description: "des", imageFilename: "pic.jpg");
            return new List<Artist>
            {
                new Artist
                (
                    Name: "Sam Smith",
                    AlbumName: "The thrill of it all",
                    Description: "",
                    Date: new DateTime(2017, 11, 03),
                    imageFilename:  "SamSmith.jpg"
                ),
                new Artist
                (
                    Name: "Tupac Shakur",
                    AlbumName: "All Eyez on Me",
                    Description: "",
                    Date: new DateTime(1996, 02, 13),
                    imageFilename: "Tupac.jpg"
                ),
                new Artist
                (
                    Name: "Fallout boy",
                    AlbumName: "Mania",
                    Description: "",
                    Date: new DateTime(2018, 01, 19),
                    imageFilename: "FOB.jpg"
                ),
                new Artist
                (
                    Name: "Ed Sheeran",
                    AlbumName: "Divide",
                    Description: "",
                    Date: new DateTime(2017, 03, 17),
                    imageFilename: "EdSheeran.jpg"
                ),
                new Artist
                (
                    Name: "Amadeus Mozart",
                    AlbumName: "Symphony No. 25 in G Minor",
                    Description: "",
                    Date: new DateTime(1773, 10, 05),
                    imageFilename: "Mozart.jpg"
                ),
                new Artist
                (
                    Name: "Drake",
                    AlbumName: "Views",
                    Description: "",
                    Date: new DateTime(2017, 03, 16),
                    imageFilename: "Drake.png"
                ),



            };
            
        }


    }
}