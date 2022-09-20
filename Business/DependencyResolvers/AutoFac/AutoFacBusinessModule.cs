using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module //Business ve WebAPI e utofac yukle nu getpack
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthManager>();

            builder.RegisterType<UserManager>().As<IUserManager>();
            builder.RegisterType<UserDal>().As<IUserDal>();

            builder.RegisterType<BlogManager>().As<IBlogService>();
            builder.RegisterType<BlogDal>().As<IBlogDal>();


        }

    }
}
