using NorthwindApp.BLL.Abstract;
using NorthwindApp.BLL.Specs.ProductSpecs;
using NorthwindApp.BLL.ValidationRules.FluentValidation;
using NorthwindApp.Helpers.Aspects.ValidationAspects;
using NorthwindApp.Helpers.CrossCuttingConcern.ExceptionHandling.Exceptions;
using NorthwindApp.Helpers.Utilities.Encryption;
using NorthwindApp.Helpers.Utilities.Mapper;
using NorthwindApp.Helpers.Utilities.Search;
using NorthwindApp.Interfaces;
using System.Collections.Generic;

namespace NorthwindApp.BLL.Concrete.Managers
{
    public class Product
        : NorthwindApp.Entities.CORE.Product, IProductService
    {
        IProductDal _productDal;
        int EKS = 0;

        public Product(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public int Add(Entities.DTO.Product product)
        {
            if ((ProductSpecs.ProductNameMustBeUnique).
                 IsSatisfiedBy(product))
            {
                //Burada dynamic bir yapı olacak
                QueryParam[] parametreler = new QueryParam[]
                {
                    new QueryParam{ParamName="CategoryID",ParamValue=product.CategoryID},
                    new QueryParam{ParamName="ProductName",ParamValue=product.ProductName},
                    new QueryParam{ParamName="QuantityPerUnit",ParamValue=product.QuantityPerUnit},
                    new QueryParam{ParamName="UnitPrice",ParamValue=product.UnitPrice},
                    new QueryParam{ParamName="UnitsInStock",ParamValue=product.UnitsInStock},
                    new QueryParam{ParamName="Discontinued",ParamValue=product.Discounted}
                };
                EKS = _productDal.Execute(NorthwindApp.StoredProcedures.Product.AddProduct, parametreler);
            }

            //Burası değişebilir
            foreach (var businessException in BusinessRules.BusinessExceptions)
            {
                throw businessException;
            }

            return EKS;
        }

        public int Delete(string id)
        {
            QueryParam[] parametreler = new QueryParam[]
            {
                new QueryParam{ParamName="Id",ParamValue=Encryptor.Decrypt(id)}
            };
            return _productDal.Execute(NorthwindApp.StoredProcedures.Product.DeleteProduct, parametreler);
        }

        public Entities.DTO.Product Get(string id)
        {
            QueryParam[] parametreler = new QueryParam[]
            {
                new QueryParam{ParamName="ProductId",ParamValue=Encryptor.Decrypt(id)}
            };

            var result = _productDal.Get(NorthwindApp.StoredProcedures.Product.GetProductbyId, parametreler);
            NorthwindApp.Entities.DTO.Product productDTO = new Entities.DTO.Product();
            SimpleMapper.PropertyMap(result, productDTO);
            return productDTO;
        }

        //[CacheAspect(30)]
        public List<Entities.DTO.Product> GetAll(int pageSize, int pageNumber)
        {
            QueryParam[] parametreler = new QueryParam[]
            {
                new QueryParam{ParamName="@PageSize",ParamValue=pageSize},
                new QueryParam{ParamName="@PageNumber",ParamValue=pageNumber}
            };
            var result = _productDal.GetList(NorthwindApp.StoredProcedures.Product.GetAllProducts, parametreler);
            List<NorthwindApp.Entities.DTO.Product> productDTO = new List<Entities.DTO.Product>();
            SimpleMapper.PropertyMap(result, productDTO);
            //Burada daha farklı bir çözüm dene
            //foreach (var item in productDTO)
            //{
            //    item.ProductID = Encryptor.Encrypt(item.ProductID);
            //}
            return productDTO;
        }

        public List<Entities.DTO.Product> GetByCategory(int categoryId)
        {
            QueryParam[] parametreler = new QueryParam[]
            {
                new QueryParam{ParamName="@CategoryID",ParamValue=categoryId}
            };

            var result = _productDal.GetList(NorthwindApp.StoredProcedures.Product.GetProductsByCategoryID, parametreler);
            List<NorthwindApp.Entities.DTO.Product> productDTO = new List<Entities.DTO.Product>();
            SimpleMapper.PropertyMap(result, productDTO);
            //Burada şifreleme olacak
            return productDTO;
        }

        public int GetProductCount()
        {
            return _productDal.Scalar<int>(NorthwindApp.StoredProcedures.Product.GetProductCount);
        }

        //Burada validation olacak
        //Gelince buradan devam et
        [FluentValidationAspect(typeof(Product))]
        public int Update(Entities.DTO.Product product)
        {
            QueryParam[] parametreler = new QueryParam[]
            {
                new QueryParam{ParamName="",ParamValue=product.CategoryID},
                new QueryParam{ParamName="",ParamValue=product.CategoryID},
                new QueryParam{ParamName="",ParamValue=product.CategoryID},
                new QueryParam{ParamName="",ParamValue=product.CategoryID},
                new QueryParam{ParamName="",ParamValue=product.CategoryID},
                new QueryParam{ParamName="",ParamValue=product.CategoryID}
            };
            return _productDal.Execute(NorthwindApp.StoredProcedures.Product.UpdateProduct, parametreler);
        }
    }
}
