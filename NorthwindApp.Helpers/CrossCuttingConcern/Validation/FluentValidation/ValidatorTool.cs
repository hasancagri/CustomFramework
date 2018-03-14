using FluentValidation;
using NorthwindApp.Helpers.CrossCuttingConcern.ExceptionHandling.Exceptions;

namespace NorthwindApp.Helpers.CrossCuttingConcern.Validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);

            foreach (var error in result.Errors)
            {
                throw new ValidationCoreException(error.ErrorMessage);
            }
        }
    }
}
