
namespace ShopTask4.Data.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using ShopTask4.Data.interfaces;
    using ShopTask4.Data.Models;

    public class CarRepository : IAllCars
    {
        private readonly AddDBContent addDBContent;

        public CarRepository(AddDBContent addDBContent)
        {
            this.addDBContent = addDBContent;
        }

        public IEnumerable<Car> Cars => addDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavoriteCars => addDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);
        public Car GetCar(int carId) => addDBContent.Car.FirstOrDefault(c => c.Id == carId);

    }
}
