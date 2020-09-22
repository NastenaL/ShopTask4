namespace ShopTask4.Data
{
    using Microsoft.EntityFrameworkCore;
    using ShopTask4.Data.Models;

    public class AddDBContent : DbContext
    {
        public AddDBContent(DbContextOptions<AddDBContent> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
