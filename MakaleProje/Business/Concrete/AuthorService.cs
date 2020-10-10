using Business.Abstract;
using DataAccess.Abstract;
using Entities;
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
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
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
