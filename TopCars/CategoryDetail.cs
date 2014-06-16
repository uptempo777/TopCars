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
    public class CategoryDetail : TabbedPage
    {
        public CategoryDetail(Category category)
        {
            var viewModel = new CategoryDetailViewModel();

            Title = "Top 10 " + category.Name;

            var newPage = new ListDetail();
            var usedPage = new ListDetail();
            var bestGasMileagePage = new ListDetail();
            var worstGasMileagePage = new ListDetail();
            var leastExpensivePage = new ListDetail();
            var mostExpensivePage = new ListDetail();
            var highestHorsepowerPage= new ListDetail();
            var lowestHorsepowerPage= new ListDetail();

            newPage.Title = "New";
            usedPage.Title = "Used";
            bestGasMileagePage.Title = "Best Gas Mileage";
            worstGasMileagePage.Title = "Worst Gas Mileage";
            leastExpensivePage.Title = "Least Expensive";
            mostExpensivePage.Title = "Most Expensive";
            highestHorsepowerPage.Title = "Highest Horsepower";
            lowestHorsepowerPage.Title = "Lowest Horsepower";

            Children.Add(newPage);
            Children.Add(usedPage);
            Children.Add(bestGasMileagePage);
            Children.Add(worstGasMileagePage);
            Children.Add(leastExpensivePage);
            Children.Add(mostExpensivePage);
            Children.Add(highestHorsepowerPage);
            Children.Add(lowestHorsepowerPage);

            // ItemsSource = viewModel.Classifications;

            // ItemsSource = viewModel.Classifications;

            //var cell = new DataTemplate(typeof(TextCell));

            //cell.SetBinding(TextCell.TextProperty, "Name");

            //ItemTemplate = new DataTemplate(() =>
            //{
            //    return new ListDetail();
            //});

            //var list = new ListView();

            //list.ItemsSource = viewModel.Classifications;

            //var cell = new DataTemplate(typeof(TextCell));

            //cell.SetBinding(TextCell.TextProperty, "Name");
            //list.ItemTemplate = cell;


            //Content = list;
        }
    }
}
