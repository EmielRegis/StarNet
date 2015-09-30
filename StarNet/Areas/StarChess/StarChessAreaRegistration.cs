using System.Web.Mvc;

namespace StarNet.Areas.StarChess
{
    public class StarChessAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StarChess";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StarChess_default",
                "StarChess/{controller}/{action}/{id}",
                defaults: new { controller = "StarChessHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}