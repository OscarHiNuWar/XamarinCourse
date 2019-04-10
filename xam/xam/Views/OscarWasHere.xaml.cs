using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xam.Views;
using xam.Models;
using Plugin.Toast;

namespace xam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OscarWasHere : ContentPage
    {
        public OscarWasHere()
        {
            InitializeComponent();
        }

        async void Item_Clicked(object sender, System.EventArgs e)
        {
            CrossToastPopUp.Current.ShowToastMessage("What a great Game!");
            await Navigation.PushAsync(new AboutGame((GamesList.SelectedItem as Games).Name, (GamesList.SelectedItem as Games).Descriptions));
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
    }
}