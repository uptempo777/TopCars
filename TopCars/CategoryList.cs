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
    public class CarImageCell : ViewCell
    {
        public CarImageCell()
        {
            var image = new Image();

            image.SetBinding(Image.SourceProperty, new Binding("Url"));
            // image.WidthRequest = image.HeightRequest = 40;

            var name = new Label();

            name.SetBinding(Label.TextProperty, "Name");

            var viewLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = {  image, name }
            };

            View = viewLayout;
        }
            
    }

    public class CategoryList : ContentPage
    {
        public CategoryList()
        {
            var viewModel = new CategoryListViewModel();
            Title = "Top 10 Cars";
            var list = new ListView();

            list.ItemsSource = viewModel.Categories;

            var cell = new DataTemplate(typeof(CarImageCell));


            //var cell = new DataTemplate(typeof(ImageCell));

            //cell.SetBinding(ImageCell.TextProperty, "Name");
            //cell.SetBinding(ImageCell.ImageSourceProperty, "Url");

            list.ItemTemplate = cell;

            list.ItemTapped += (sender, args) =>
            {
                var category = args.Item as Category;
                if (category == null)
                    return;

                Navigation.PushAsync(new CategoryDetail(category));

                list.SelectedItem = null;

            };

            Content = list;
        }

    }
}
