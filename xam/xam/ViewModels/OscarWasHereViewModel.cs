using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using xam.Models;

namespace xam.ViewModels
{
    class OscarWasHereViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Games> Game { get; set; }

        public OscarWasHereViewModel()
        {
            Game = new ObservableCollection<Games>
            {
                new Games
                {
                    //Picture = "",
                    Name = "Persona 3 FES",
                    Descriptions = "An RPG"
                },
                new Games
                {
                    //Picture = "",
                    Name = "Persona 5",
                    Descriptions = "An RPG"
                },
                new Games
                {
                    //Picture = "",
                    Name = "Darkest Dungeon",
                    Descriptions = "An RPG"
                },
                new Games
                {
                    //Picture = "",
                    Name = "Dark Souls - Remaster",
                    Descriptions = "A masochist RPG"
                },
                new Games
                {
                    //Picture = "",
                    Name = "Bloodborne",
                    Descriptions = "An masochist Action Game"
                },
                new Games
                {
                    //Picture = "",
                    Name = "Devil May Cry 5",
                    Descriptions = "An Action Game"
                },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
