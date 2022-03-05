using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddMessage(Message message)
        {
            _messageDal.Insert(message);
        }

        public void DeleteMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(m => m.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(m => m.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendBox()
        {
            return _messageDal.List(m => m.SenderMail == "admin@gmail.com");
        }

        public void UpdateMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
