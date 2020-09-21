namespace ShopTask4.Data.interfaces
{
    using ShopTask4.Data.Models;
    using System.Collections.Generic;

    interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        IEnumerable<Car> GetFavoriteCars { get; set; }
        Car GetCar { get; set; }
    }
}
