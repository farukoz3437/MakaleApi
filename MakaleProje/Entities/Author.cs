using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entities
{
    public class Author:IEntity
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
    }
}
