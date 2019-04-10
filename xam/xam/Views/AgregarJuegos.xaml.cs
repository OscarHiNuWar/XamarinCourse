using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xam.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;


namespace xam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarJuegos : ContentPage
    {
        public Models.Games Games { get; set; }

        public AgregarJuegos()
        {
            InitializeComponent();

            Games = new Games
            {
                Name = "",
                Descriptions = ""
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Games);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}