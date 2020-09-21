namespace ShopTask4.Data.interfaces
{
    using ShopTask4.Data.Models;
    using System.Collections.Generic;

    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCars { get; set; }
        Car GetCar { get; set; }
    }
}
