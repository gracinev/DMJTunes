using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Team_Project
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class AlbumPage : Page
   {
        public List<Artist> Artists { get; set; }
        public AlbumPage()
      {
         this.InitializeComponent();
         Artists = Artist.AllArtists();
        
      }

        private void album_list_view_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Artist a = (Artist)album_list_view.SelectedItem;
            this.Frame.Navigate(typeof(ArtistInfo),a);
        }
    }
}
