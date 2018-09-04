using iAssetTechnicalTest_MVCWebAPI_4Dot5.Service;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IWeatherService, WeatherService>();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}