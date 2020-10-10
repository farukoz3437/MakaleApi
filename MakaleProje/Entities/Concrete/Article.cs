using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Article:IEntity
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ArticleReleaseDate { get; set; }
        public DateTime ArticleCreateDate { get; set; }
        public int AuthorId { get; set; }
    }
}
