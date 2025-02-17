using Exercise3_RestApi.Domain;
using FluentValidation;
namespace Exercise3_RestApi.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty();
            RuleFor(product => product.Name).MaximumLength(AppConstants.ProductNameLength).WithMessage(AppConstants.ProductNameLengthMessage);
            RuleFor(product => product.Description).NotEmpty();
            RuleFor(product => product.Description).MaximumLength(AppConstants.ProductDescriptionLength).WithMessage(AppConstants.ProductDescriptionLengthMessage);
        }
    }
}
