using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        Author GetById(int authorId);
        List<Author> GetList();
        List<Author> GetListByAuthorId(int authorId);
        string Add(Author author);
        string Delete(Author author);
        string Update(Author author);
    }
}
