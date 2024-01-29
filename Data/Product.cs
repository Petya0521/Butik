using System.ComponentModel;

namespace Dp_Butik.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int CatalogNum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        public int TypeProductId { get; set; } 
        public TypeProduct TypeProducts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
