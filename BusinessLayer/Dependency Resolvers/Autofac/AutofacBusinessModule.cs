using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Concretes;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAboutDal>().As<IAboutDal>().SingleInstance();
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            
            builder.RegisterType<EfBlogDal>().As<IBlogDal>().SingleInstance();
            builder.RegisterType<BlogManager>().As<IBlogService>().SingleInstance();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();

            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();

            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();
            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();

            builder.RegisterType<EfWriterDal>().As<IWriterDal>().SingleInstance();
            builder.RegisterType<WriterManager>().As<IWriterService>().SingleInstance();

            builder.RegisterType<EfNewsLetterDal>().As<INewsLetterDal>().SingleInstance();
            builder.RegisterType<NewsLetterManager>().As<INewsLetterService>().SingleInstance();

            builder.RegisterType<EfSocialMediaDal>().As<ISocialMediaDal>().SingleInstance();
            builder.RegisterType<SocialMediaManager>().As<ISocialMediaService>().SingleInstance();

            builder.RegisterType<LoginManager>().As<ILoginService>().SingleInstance();




        }
    }
}
