using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TopCars
{
    public class App
    {
        public static Page GetMainPage()
        {
            var categories = new CategoryList();
            return new NavigationPage(categories);
        }
    }
}
