namespace ShopTask4.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Image { get; set; }
        public ushort Price { get; set; }
        public bool IsFavourite { get; set; }
        public int Awaitable { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
