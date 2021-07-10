namespace WebApplication1.Validators
{
    using FluentValidation;

    public class CalcReqValidator : AbstractValidator<Dto.CalcReq>
    {
        public CalcReqValidator()
        {
            RuleFor(x => x.A).InclusiveBetween(1, 9);
            RuleFor(x => x.B).InclusiveBetween(1, 9);
        }
    }
}
