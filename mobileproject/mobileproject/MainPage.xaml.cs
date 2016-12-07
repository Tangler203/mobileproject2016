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
using Newtonsoft.Json;
using System.Net.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace mobileproject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Movie movie;
        string output;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
          
            MovieReader m = new MovieReader();
            getMovie(TextInput.Text);
        }

        private async void upload(object sender, RoutedEventArgs e)
        {

            //await App.MobileService.GetTable<Movie>().InsertAsync(movie);
        }

        private async void getMovie(string query)
        {
            string url = "http://www.omdbapi.com/?t=" + query + "&y=&plot=short&r=json";
            var client = new HttpClient();

            var response = await client.GetAsync(url);

            output = await response.Content.ReadAsStringAsync();
            movie = JsonConvert.DeserializeObject<Movie>(output);
            movieItem.Text = movie.title +"\nStarring:" + movie.actor+ "\nDirected by "+ movie.director + "\nReleased: " + movie.year + "\nRunning Time:" + movie.runtime + "\n\n\n" + movie.plot;
           



        }

        private void CheckBoxComplete_Checked(object sender, RoutedEventArgs e)
        {
            //CheckBox cb = (CheckBox)sender;
            //TodoItem item = cb.DataContext as TodoItem;
            //await UpdateCheckedTodoItem(item);
        }
    }
}
