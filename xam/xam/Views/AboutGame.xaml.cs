using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutGame : ContentPage
    {
        public AboutGame(string title, string description)
        {
            InitializeComponent();
            gameTitle.Text = title;
            gameDescription.Text = description;
        }
    }
}