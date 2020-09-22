namespace ShopTask4.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ShopTask4.Data.interfaces;
    using ShopTask4.ViewModels;

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
            ViewBag.Title = "Page with autos";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = allCars.Cars;
            obj.CarCategory = "Autos";
            return View(obj);
        }
    }
}
