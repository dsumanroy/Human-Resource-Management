
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/HrmSalaryProcess"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HrmSalaryProcessRow))]
    public class HrmSalaryProcessController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/HrmSalaryProcess/HrmSalaryProcessIndex.cshtml");
        }
    }
}