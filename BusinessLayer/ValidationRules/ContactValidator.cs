using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş bırakamazsınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş bırakamazsınız.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş bırakamazsınız.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu minimum üç karakterden oluşmalıdır.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı adı minimum üç karakterden oluşmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu maximum elli karakterden oluşmalıdır.");
        }
    }
}
