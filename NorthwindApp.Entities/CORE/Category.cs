using System.Collections.Generic;

namespace NorthwindApp.Entities.CORE
{
    public class Category
        : BaseOBJ
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<NorthwindApp.Entities.CORE.Product> Products { get; set; }
    }
}
