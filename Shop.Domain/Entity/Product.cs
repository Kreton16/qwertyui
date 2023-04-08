
using Shop.Domain.Enum;

namespace Shop.Domain.Entity
{
    internal class Product
    {
        public int Id { get; set; }
        public CategoryAge CategoryAge { get; set; }
        public CategoryGender CategoryGender { get; set; }
        public CategorySeason CategorySeason { get; set; }
        public CategorySize CategorySize { get; set; }
        public CategoryTypes CategoryTypes { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsFeatured { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; } 
    }
}
