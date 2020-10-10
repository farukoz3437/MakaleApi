using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business.Concrete
{
    public class AuthorService : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorService(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public string Add(Author author)
        {
            _authorDal.Add(author);
            return "Yazar başarıyla eklendi";
            
        }

        public string Delete(Author author)
        {
            _authorDal.Delete(author);
            return "Yazar başarıyla silindi";
        }

        public string Update(Author author)
        {
            _authorDal.Update(author);
            return "Yazar başarıyla güncellendi";
        }

        public Author GetById(int authorId)
        {
            return _authorDal.Get(filter: x => x.AuthorId == authorId);
        }

        public List<Author> GetList()
        {
            return _authorDal.GetList().ToList();
        }

        public List<Author> GetListByAuthorId(int authorId)
        {
            return _authorDal.GetList(filter: x => x.AuthorId == authorId).ToList();
        }

     
    }
}
