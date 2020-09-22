namespace ShopTask4.ViewModels
{
    using ShopTask4.Data.Models;
    using System.Collections.Generic;

    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string CarCategory { get; set; }
    }
}
