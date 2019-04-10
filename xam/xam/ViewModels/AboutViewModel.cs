using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace xam.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Oscar was Here";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/OscarHiNuWar/XamarinCourse")));
        }

        public ICommand OpenWebCommand { get; }
    }
}