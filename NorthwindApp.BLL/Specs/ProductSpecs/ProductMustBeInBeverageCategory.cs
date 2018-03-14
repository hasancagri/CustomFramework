using NorthwindApp.Helpers.CrossCuttingConcern.ExceptionHandling.Exceptions;
using NorthwindApp.Helpers.Utilities.SpecificationBase;

namespace NorthwindApp.BLL.Specs.ProductSpecs
{
    public class ProductMustBeInBeverageCategory
        : Specification<NorthwindApp.Entities.DTO.Product>
    {
        public override bool IsSatisfiedBy(NorthwindApp.Entities.DTO.Product candidate)
        {
            if (candidate.CategoryID != 1)
            {
                BusinessRules.Add(new BusinessException("Ürün içecek kategorisinde olmalıdır"));
                return false;
            }
            return true;
        }
    }
}
