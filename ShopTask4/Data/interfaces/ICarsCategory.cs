namespace ShopTask4.Data.interfaces
{
    using ShopTask4.Data.Models;
    using System.Collections.Generic;

    public interface ICarsCategory
    {
       IEnumerable<Category> AllCategories { get; }
    }
}
