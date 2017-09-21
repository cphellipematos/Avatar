using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Data.CrossCutting.IoC
{
    public static class SimpleInjectorInitialize
    {
        public static void ApplicationServices(Container container)
        {
            //container.Register<Interface, ConcreteClass>(Lifestyle.Scoped);
            //container.Register<Data>(Lifestyle.Scoped);

            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App


            // Domain



            // Infra Dados


        }
    }
}
