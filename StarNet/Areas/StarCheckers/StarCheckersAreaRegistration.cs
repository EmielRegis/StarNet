using System.Web.Mvc;

namespace StarNet.Areas.StarCheckers
{
    public class StarCheckersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StarCheckers";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StarCheckers_default",
                "StarCheckers/{controller}/{action}/{id}",
                defaults: new { controller = "StarCheckersHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}