namespace ShopTask4.Data.Models
{
    using System.Collections.Generic;
    public class Category
    {
        public int  Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Car> Cars { get; set; }
    }
}
