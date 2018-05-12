
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/PrmDesignation"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PrmDesignationRow))]
    public class PrmDesignationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/PrmDesignation/PrmDesignationIndex.cshtml");
        }
    }
}