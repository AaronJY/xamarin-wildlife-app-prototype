using System;
using System.Collections.Generic;
using System.Text;

namespace Wildlife.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Camera
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
