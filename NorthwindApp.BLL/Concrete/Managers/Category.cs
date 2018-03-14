using NorthwindApp.BLL.Abstract;
using NorthwindApp.Entities.DTO;
using NorthwindApp.Entities.WEB;
using NorthwindApp.Helpers.Utilities.Mapper;
using NorthwindApp.Interfaces;
using System.Collections.Generic;

namespace NorthwindApp.BLL.Concrete.Managers
{
    public class Category
        : NorthwindApp.Entities.CORE.Category, ICategoryService
    {
        ICategoryDal _categoryDal;
        public Category(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Entities.DTO.Category> GetAll()
        {
            var result = _categoryDal.GetList(NorthwindApp.StoredProcedures.Category.GetAllCategories, null);
            List<NorthwindApp.Entities.DTO.Category> categoryDTO = new List<Entities.DTO.Category>();
            SimpleMapper.PropertyMap(result, categoryDTO);
            return categoryDTO;
        }

        public List<Entities.DTO.Category> GetCategoriesWithProduct()
        {
            var result = _categoryDal.GetCategoriesWithProduct(NorthwindApp.StoredProcedures.Category.GetCategoriesWithProduct, null);
            List<NorthwindApp.Entities.DTO.Category> categoryDTO = new List<Entities.DTO.Category>();
            SimpleMapper.PropertyMap(result, categoryDTO);
            return categoryDTO;
        }

        public List<CategorySurrogate> GetListForProduct()
        {
            var result = _categoryDal.GetList(NorthwindApp.StoredProcedures.Category.GetCategoryListForProduct, null);
            List<NorthwindApp.Entities.WEB.CategorySurrogate> categoryDTO = new List<CategorySurrogate>();
            SimpleMapper.PropertyMap(result, categoryDTO);
            return categoryDTO;
        }
    }
}
