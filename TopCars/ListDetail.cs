using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCars.Models;
using TopCars.ViewModels;
using Xamarin.Forms;
namespace TopCars
{
    public class ListDetail : CarouselPage
    {
        public ListDetail()
        {



            Children.Add(CreateCar("#10 2012 Aston Martin Virage",
                "http://img.autobytel.com/2012/aston-martin/virage/2-800-oemexteriorfront-67254.jpg"));
            Children.Add(CreateCar("#9 2014 Lexus ES-300h",
                "http://img.autobytel.com/2014/lexus/es-300h/2-800-oemexteriorfront-72650.jpg"));
            Children.Add(CreateCar("#8 2013 BMX X5-2",
                "http://img.autobytel.com/2013/bmw/x5-m/2-800-threequartersview-68327.jpg"));
            Children.Add(CreateCar("#7 2015 Audi TT",
                "http://img.autobytel.com/2015/audi/tt/2-800-oemexteriorfront-73203.jpg"));
            Children.Add(CreateCar("#6 2014 Chrysler Town and Country",
                "http://img.autobytel.com/2014/chrysler/town-and-country/2-800-oemexteriorfront-71870.jpg"));
            Children.Add(CreateCar("#5 2014 Mercedes Benz G-Class",
                "http://img.autobytel.com/2014/mercedes-benz/g-class/2-800-oemexteriorfront-72663.jpg"));
            Children.Add(CreateCar("#4 2015 Mazda Mazda 6",
                "http://img.autobytel.com/2015/mazda/mazda6/2-800-oemexteriorfront-73413.jpg"));
            Children.Add(CreateCar("#3 2014 Toyota Prius-C",
                "http://img.autobytel.com/2014/toyota/prius-c/2-800-oemexteriorfront-73073.jpg"));
            Children.Add(CreateCar("#2 2013 Mini Coupe",
                "http://img.autobytel.com/2013/mini/coupe/2-800-oemexteriorfront-70116.jpg"));
            Children.Add(CreateCar("#1 2012 Aston Martin Virage",
                "http://img.autobytel.com/2012/aston-martin/virage/2-800-oemexteriorfront-67254.jpg"));
            

            
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2014/lexus/es-300h/2-800-oemexteriorfront-72650.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2014/infiniti/qx70/2-800-threequartersview-72060.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2013/bmw/x5-m/2-800-threequartersview-68327.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2015/audi/tt/2-800-oemexteriorfront-73203.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2014/chrysler/town-and-country/2-800-oemexteriorfront-71870.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2014/mercedes-benz/g-class/2-800-oemexteriorfront-72663.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2015/mazda/mazda6/2-800-oemexteriorfront-73413.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2014/toyota/prius-c/2-800-oemexteriorfront-73073.jpg" } });
            //Children.Add(new ContentPage { Content = new Image() { Source = "http://img.autobytel.com/2013/mini/coupe/2-800-oemexteriorfront-70116.jpg" } });
        }

        public ContentPage CreateCar(string name, string imageUrl)
        {
            var image = new Image()
            {
                Source = imageUrl
            };

            var carName = new Label
            {
                Text = name
            };

            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {  image, carName }
            };

            return new ContentPage
            {
                Content = stackLayout
            };

        }
    }
}
