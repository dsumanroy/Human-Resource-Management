
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/PrmEmploymentInfo"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PrmEmploymentInfoRow))]
    public class PrmEmploymentInfoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/PrmEmploymentInfo/PrmEmploymentInfoIndex.cshtml");
        }
    }
}