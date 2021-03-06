﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private IArticleDal _IArticleDal;

        public ArticleService(IArticleDal articleDal)
        {
            _IArticleDal = articleDal;
        }

        public string Add(Article article)
        {
            _IArticleDal.Add(article);
            return "Makale başarıyla eklendi";
        }

        public string Delete(Article article)
        {
            _IArticleDal.Delete(article);
            return "Makale başarıyla silindi";
        }

        public string Update(Article article)
        {
            _IArticleDal.Update(article);
            return "Makale başarıyla güncellendi";
        }

        public Article GetById(int articleId)
        {
            return _IArticleDal.Get(filter: x => x.ArticleId == articleId);
        }

        public List<Article> GetList()
        {
            return _IArticleDal.GetList().ToList();
        }

        public List<Article> GetListByArticleId(int articleId)
        {
            return _IArticleDal.GetList(filter: x => x.ArticleId == articleId).ToList();
        }

     
    }
}
