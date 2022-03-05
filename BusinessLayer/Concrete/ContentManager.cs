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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public void AddContent(Content content)
        {
            _contentDal.Insert(content);
        }

        public void DeleteContent(Content content)
        {
            _contentDal.Delete(content);
        }

        public Content GetById(int id)
        {
            return null;
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(c => c.HeadingID == id);
        }

        public List<Content> List()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByWriter()
        {
            return _contentDal.List(x => x.WriterID == 4);
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
