using System.Collections.Generic;

namespace NorthwindApp.Entities.DTO
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<NorthwindApp.Entities.DTO.Product> Products { get; set; }
    }
}
