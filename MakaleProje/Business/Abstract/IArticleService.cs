using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        Article GetById(int articleId);
        List<Article> GetList();
        List<Article> GetListByArticleId(int articleId);
        void Add(Article article);
        void Delete(Article article);
        void Update(Article article);
    }
}
