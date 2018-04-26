using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Team_Project
{
    public class Artist
    {
        public string ArtistName { get; set; }
        public string AlbumDescription { get; set; }
        public string AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Image AlbumArtwork { get; set; }

        public Artist()
        {

        }
        public Artist(string artistName, string albumDescription, string albumName, DateTime date, string imageFilename)
        {
            this.ArtistName = artistName;
            this.AlbumDescription = albumDescription;
            this.AlbumName = albumName;
            this.ReleaseDate = date;
            AlbumArtwork = new Image();
            AlbumArtwork.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{imageFilename}", UriKind.RelativeOrAbsolute));
        }
        public string YearOnly
        {
            get
            {
                return $"({ReleaseDate.Year})";
            }
        }
        public static List<Artist> AllArtists()
        {
            return new List<Artist>
            {
                new Artist
                (
                    artistName: "Sam Smith",
                    albumName: "The Thrill of It All",
                    albumDescription: "Sam Smith is an old soul with an easily bruised heart. He’s looking for radiant, cinematic love, the kind that springs from a meet-cute at the supermarket when you reach for a can of soup and happen to bump into the man of your dreams. He knows what it’s like to yearn for someone who barely notices you’re alive. He’s well acquainted with romantic desperation, the kind of pitiable state where you betray everything you believe in because you’re just so lonely. And he became one of this decade’s biggest pop stars because he was willing to take all of those desires, no matter how embarrassing, and lay them out in terms everyone can understand.",
                    date: new DateTime(2017, 11, 03),
                    imageFilename:  "ThrillOfItAll.png"
                ),
                new Artist
                (
                    artistName: "Tupac",
                    albumName: "All Eyez on Me",
                    albumDescription: "The title of 2PAC's fourth album, All Eyez on Me, is not just a reflection of his usual arrogance and paranoia — people are watching 2Pac. This two-disc set comes just four months after he was released on bail pending appeal on his conviction for sexual assault. It comes barely a year after he was shot. Most important, All Eyez on Me marks 2Pac's new allegiance with the West Coast's powerhouse rap dynasty, Death Row Records.",
                    date: new DateTime(1996, 02, 13),
                    imageFilename: "tupacAlbum.jpg"
                ),
                new Artist
                (
                    artistName: "Fall Out Boy",
                    albumName: "Mania",
                    albumDescription: "M A N I A stumbled out of the gate after missing its initial release date last September, following the muted reaction to early singles like “Young and Menace,” which wedded EDM drops to heavy metal bombast. Bassist-lyricist Pete Wentz reassured fans that it would be the only song on the album that “sounds vaguely like a kitten chasing a laser around,” but the track still opens M A N I A, and feels like a gutsy line drawn in the sand.",
                    date: new DateTime(2018, 01, 19),
                    imageFilename: "Mania.png"
                ),
                new Artist
                (
                    artistName: "Ed Sheeran",
                    albumName: "Divide",
                    albumDescription: "On Ed Sheeran's third album ÷ [Divide], he sets out to go even bigger than with its predecessors. Previously listed at 12 tracks, the ‘deluxe’ version has 16 songs and runs at about an hour. Undoubtedly it's set to enjoy several weeks, if not months, at the top of the album charts and likely smash several records along the way. And in that sense Divide is astonishing for its sheer ambition alone; this is a polished, well-executed effort from one of the hardest-working men in music.",
                    date: new DateTime(2017, 03, 17),
                    imageFilename: "Divide.jpg"
                ),
                new Artist
                (
                    artistName: "Amadeus Mozart",
                    albumName: "Symphony No. 25 in G Minor",
                    albumDescription: "The Symphony No. 25 in G minor, K. 183/173dB, was written by the then 17-year-old Wolfgang Amadeus Mozart in October 1773,[1] shortly after the success of his opera seria Lucio Silla. It was supposedly completed in Salzburg on October 5, a mere two days after the completion of his Symphony No. 24, although this remains unsubstantiated. Its first movement is widely known as the opening music in Miloš Forman's film Amadeus.",
                    date: new DateTime(1773, 10, 05),
                    imageFilename: "MozartGMinor.jpg"
                ),
                new Artist
                (
                    artistName: "Drake",
                    albumName: "Views",
                    albumDescription: "The album was supported by five singles: Hotline Bling, One Dance, Pop Style, Controlla and Too Good. Views was met with lukewarm reviews from critics, many of whom found it to be an overlong retread of Drake's previous work. Despite this, it spent 13 non-consecutive weeks at number one on the US Billboard 200. Views became the first album to accumulate one-billion streams on Apple Music.[8] On December 1, 2016, Views was certified quadruple Platinum by the Recording Industry Association of America (RIAA).",
                    date: new DateTime(2017, 03, 16),
                    imageFilename: "Views.jpg"
                ),



            };
            
        }


    }
}