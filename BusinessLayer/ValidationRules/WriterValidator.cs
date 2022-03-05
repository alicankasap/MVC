using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş bırakamazsınız.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı minimum iki karakterden oluşmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı maximum elli karakterden oluşmalıdır.");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Yazar soyadı minimum iki karakterden oluşmalıdır.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Yazar soyadı maximum elli karakterden oluşmalıdır.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş bırakamazsınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş bırakamazsınız.");
        }
    }
}
