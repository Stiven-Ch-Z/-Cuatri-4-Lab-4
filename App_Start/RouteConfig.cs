using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace TallerMecanico
{
    public static class RouteConfig//clase estatica de configuracion 
    {
        public static void RegisterRoutes(RouteCollection routes)//metodo publico para registrar
        {

            routes.MapPageRoute(//ruta que apunto la pagina web
                    routeName: "RegistrarAutos",//nombre interni
                    routeUrl: "autos/registrar",//url
                    physicalFile: "~/Views/Autos/Registrar.aspx"//pagina fisica
                );
            routes.MapPageRoute(
                    routeName: "ConsultarAutos",
                    routeUrl: "autos/consultar",
                    physicalFile: "~/Views/Autos/Consultar.aspx"
                );
            routes.MapPageRoute(
                routeName: "DemoJS", // Nombre interno 
                routeUrl: "demo/js", // URL amigable 
                physicalFile: "~/Views/Demo/JSBasico.aspx" // Página física 
                );
        }
    }
}
