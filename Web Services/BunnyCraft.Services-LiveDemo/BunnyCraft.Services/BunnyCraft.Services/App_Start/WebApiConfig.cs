namespace BunnyCraft.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.OData.Extensions;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // for v4 OData
            config.AddODataQueryFilter();
            // Cors
            config.EnableCors();

            //config.Routes.MapHttpRoute(
            //    name: "ValuesRoute",
            //    routeTemplate: "api/values/pesho/gosho/ivan/{id}",
            //    defaults: new { controller = "Values", action = "SomeName", id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApiWithActionName",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // config.Routes.MapHttpRoute(
            //     name: "DefaultApi",
            //     routeTemplate: "api/{controller}/{id}",
            //     defaults: new { id = RouteParameter.Optional }
            // );

            

            // FOR JSON
            // config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
