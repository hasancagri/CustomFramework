using System.Collections.Generic;

namespace NorthwindApp.Entities.WEB
{
    public class ProductViewModel
    {
        public List<NorthwindApp.Entities.DTO.Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
