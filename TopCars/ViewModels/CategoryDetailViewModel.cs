using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopCars.Models;

namespace TopCars.ViewModels
{
    public class CategoryDetailViewModel
    {
        public ObservableCollection<Classification> Classifications { get; set; }

        public CategoryDetailViewModel()
        {
            Classifications = new ObservableCollection<Classification>();

            Classifications.Add(new Classification()
            {
                Title = "New"
            });

            Classifications.Add(new Classification()
            {
                Title = "Used"
            });

            Classifications.Add(new Classification()
            {
                Title = "Highest Horsepower"
            });

            Classifications.Add(new Classification()
            {
                Title = "Lowest Horsepower"
            });

            Classifications.Add(new Classification()
            {
                Title = "Best Gas Mileage"
            });

            Classifications.Add(new Classification()
            {
                Title = "Worst Gas Mileage"
            });

            Classifications.Add(new Classification()
            {
                Title = "Least Expensive"
            });

            Classifications.Add(new Classification()
            {
                Title = "Most Expensive"
            });
        }

    }
}
