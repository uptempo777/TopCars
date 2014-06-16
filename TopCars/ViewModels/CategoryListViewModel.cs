using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCars.Models;

namespace TopCars.ViewModels
{
    public class CategoryListViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }

        public CategoryListViewModel()
        {
            Categories = new ObservableCollection<Category>();

            Categories.Add(new Category()
            {
                Name = "Sports Cars",
                Url = new Uri("http://img.autobytel.com/2012/aston-martin/virage/2-800-oemexteriorfront-67254.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Luxury Cars",
                Url = new Uri("http://img.autobytel.com/2014/lexus/es-300h/2-800-oemexteriorfront-72650.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "SUVs",
                Url = new Uri("http://img.autobytel.com/2014/infiniti/qx70/2-800-threequartersview-72060.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Luxury SUVs",
                Url = new Uri("http://img.autobytel.com/2013/bmw/x5-m/2-800-threequartersview-68327.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Convertibles",
                Url = new Uri("http://img.autobytel.com/2015/audi/tt/2-800-oemexteriorfront-73203.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Trucks",
                Url = new Uri("http://img.autobytel.com/2014/nissan/frontier/2-800-oemexteriorfront-73038.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Minivans",
                Url = new Uri("http://img.autobytel.com/2014/chrysler/town-and-country/2-800-oemexteriorfront-71870.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Coupes",
                Url = new Uri("http://img.autobytel.com/2014/mercedes-benz/g-class/2-800-oemexteriorfront-72663.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Sedans",
                Url = new Uri("http://img.autobytel.com/2015/mazda/mazda6/2-800-oemexteriorfront-73413.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Hybrids",
                Url = new Uri("http://img.autobytel.com/2014/toyota/prius-c/2-800-oemexteriorfront-73073.jpg")
            });

            Categories.Add(new Category()
            {
                Name = "Crossovers",
                Url = new Uri("http://img.autobytel.com/2013/mini/coupe/2-800-oemexteriorfront-70116.jpg")
            });
        }
    }
}
