namespace ShopTask4.Data.Repository
{
    using ShopTask4.Data.Models;
    using System.Collections.Generic;
    using ShopTask4.Data.interfaces;

    public class CategoryRepository : ICarsCategory
    {
        private readonly AddDBContent addDBContent;

        public CategoryRepository(AddDBContent addDBContent)
        {
            this.addDBContent = addDBContent;
        }

        public IEnumerable<Category> AllCategories => addDBContent.Category;
    }
}
