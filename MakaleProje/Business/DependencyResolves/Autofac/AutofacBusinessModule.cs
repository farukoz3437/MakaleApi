using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleService>().As <IArticleService>();
            builder.RegisterType<EfArticleDal>().As <IArticleDal>();

            builder.RegisterType<AuthorService>().As<IAuthorService>();
            builder.RegisterType<EfAuthorDal>().As<IAuthorDal>();
        }
    }
}
