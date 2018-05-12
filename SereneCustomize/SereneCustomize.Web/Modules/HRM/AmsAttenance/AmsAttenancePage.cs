
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/AmsAttenance"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AmsAttenanceRow))]
    public class AmsAttenanceController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/AmsAttenance/AmsAttenanceIndex.cshtml");
        }
    }
}