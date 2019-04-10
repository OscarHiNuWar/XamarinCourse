using System;
using System.Collections.Generic;
using System.Text;

namespace xam.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        OscarWasHere
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
