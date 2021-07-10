namespace WebApplication1.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FluentValidation;

    public class AddReqValidator : AbstractValidator<Dto.AddReq>
    {
        public AddReqValidator()
        {
            RuleFor(x => x.A).InclusiveBetween(1, 9);
            RuleFor(x => x.B).InclusiveBetween(1, 9);
        }
    }
}
