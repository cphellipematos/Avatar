using Avatar.Application.Interfaces;
using Avatar.Application.Service;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Interfaces.Services;
using Avatar.Domain.Services;
using Avatar.Infra.Data.Repository.Context;
using Avatar.Infra.Data.Repository.Interfaces;
using Avatar.Infra.Data.Repository.Repository;
using Avatar.Infra.Data.Repository.UoW;
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

            // UoW
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            // App
            container.Register<IUserAppService, UserAppService>(Lifestyle.Scoped);
            container.Register<ICompanyAppService, CompanyAppService>(Lifestyle.Scoped);
            container.Register<IDurationTypeAppService, DurationTypeAppService>(Lifestyle.Scoped);
            container.Register<ICourseAppService, CourseAppService>(Lifestyle.Scoped);         

            // Infra Repository
            container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
            container.Register<ICompanyRepository, CompanyRepository>(Lifestyle.Scoped);
            container.Register<IDurationTypeRepository, DurationTypeRepository>(Lifestyle.Scoped);
            container.Register<ICourseRepository, CourseRepository>(Lifestyle.Scoped);

            // Infra Dados
            container.Register<AvatarContext>(Lifestyle.Scoped);                       
        }
    }
}