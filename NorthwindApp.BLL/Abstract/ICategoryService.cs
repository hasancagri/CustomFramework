using System.Collections.Generic;

namespace NorthwindApp.BLL.Abstract
{
    public interface ICategoryService
    {
        List<NorthwindApp.Entities.DTO.Category> GetAll();
        List<NorthwindApp.Entities.WEB.CategorySurrogate> GetListForProduct();
        List<NorthwindApp.Entities.DTO.Category> GetCategoriesWithProduct();
    }
}
