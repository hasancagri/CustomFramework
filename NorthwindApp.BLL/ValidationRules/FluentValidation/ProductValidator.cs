using FluentValidation;

namespace NorthwindApp.BLL.ValidationRules.FluentValidation
{
    public class ProductValidator
         : AbstractValidator<NorthwindApp.Entities.DTO.Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.ProductName).NotEmpty();
        }
    }
}
