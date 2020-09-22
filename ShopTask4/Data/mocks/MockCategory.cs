namespace ShopTask4.Data.mocks
{
    using System.Collections.Generic;
    using ShopTask4.Data.interfaces;
    using ShopTask4.Data.Models;

    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Electro", Description = "Ecologic type of cars"},
                    new Category{ CategoryName = "Patrol", Description ="Classical type of cars"}
                };
            }
            
        }
    }
}
