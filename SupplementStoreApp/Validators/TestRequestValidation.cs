using FluentValidation;
using SupplementStoreModels.Models.Requests;

namespace SupplementStoreApp.Validators

{

    public class TestRequestValidation : AbstractValidator<GetAllSupplementsByStoreRequest>
    {

        public TestRequestValidation()
        {
            RuleFor(x => x.StoreId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0).WithMessage("> 0");

            RuleFor(x => x.AfterDate)
                .NotEmpty()
                .NotNull();

        }
    }
}