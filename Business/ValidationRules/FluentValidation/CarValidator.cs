using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(100).When(p => p.ModelYear >= 2000);
            RuleFor(p => p.Description).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        //public int Id { get; set; }
        //public int BrandId { get; set; }
        //public int ColorId { get; set; }
        //public int ModelYear { get; set; }
        //public int DailyPrice { get; set; }
        //public string Description { get; set; }
    }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
