namespace ShopTask4.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ShopTask4.Data.interfaces;

    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory carsCategory;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            this.allCars = allCars;
            this.carsCategory = carsCategory;
        }

        public ViewResult List()
        {
            var cars = allCars.Cars;
            return View(cars);
        }
    }
}
