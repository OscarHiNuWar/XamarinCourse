using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xam.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameDescription : ContentPage
    {
        public GameDescription(string title, string description)
        {
            InitializeComponent();

            gameTitle.Text = title;
            gameDescription.Text = description;
        }
    }
}