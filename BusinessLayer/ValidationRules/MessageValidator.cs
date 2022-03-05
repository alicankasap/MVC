using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş bırakamazsınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş bırakamazsınız");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş bırakamazsınız");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu minimum üç karakterden oluşmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu maximum yüz karakterden oluşmalıdır.");
        }
    }
}
