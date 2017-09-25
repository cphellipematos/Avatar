using Avatar.Application.Interfaces;
using Avatar.Application.Service;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using Avatar.Domain.Services;
using Avatar.Infra.Data.Repository.Context;
using Avatar.Infra.Data.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;

namespace Avatar.Data.CrossCutting.IoC
{
    public static class SimpleInjectorInitialize
    {
        public static void ApplicationServices(Container container)
        {

            //container.Register<Data>(Lifestyle.Scoped);

            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.Register<IUserAppService, UserAppService>(Lifestyle.Scoped);
            container.Register<ICategoryAppService, CategoryAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IUserService, UserService>(Lifestyle.Scoped);
            container.Register<ICategoryService, CategoryService>(Lifestyle.Scoped);

            // Infra Repository
            container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
            container.Register<ICategoryRepository, CategoryRepository>(Lifestyle.Scoped);

            // Infra Dados
            container.Register<AvatarContext>(Lifestyle.Scoped);
        }
    }
}