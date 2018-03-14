using NorthwindApp.BLL.DependencyResolvers.Ninject;
using NorthwindApp.Helpers.CrossCuttingConcern.ExceptionHandling.Exceptions;
using NorthwindApp.Helpers.Utilities.Search;
using NorthwindApp.Helpers.Utilities.SpecificationBase;
using NorthwindApp.Interfaces;

namespace NorthwindApp.BLL.Specs.ProductSpecs
{
    public class ProductNameMustBeUnique
        : Specification<NorthwindApp.Entities.DTO.Product>
    {
        public override bool IsSatisfiedBy(NorthwindApp.Entities.DTO.Product candidate)
        {
            var productDal = InstanceFactory<IProductDal>.GetInstance();

            QueryParam[] parameters = new QueryParam[]
            {
                new QueryParam{ParamName="@ProductName",ParamValue=candidate.ProductName}
            };
            //Burada enum değişkeni olabilir
            if (productDal.Scalar<int>(NorthwindApp.StoredProcedures.Product.GetProductName,
                parameters) == 1)
            {
                BusinessRules.BusinessExceptions.Add(new BusinessException("Ürün adı unique olmalıdır"));
                return false;
            }

            return true;
        }

    }
}
