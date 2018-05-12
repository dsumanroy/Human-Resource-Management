
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/HrmSalaryComponent"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HrmSalaryComponentRow))]
    public class HrmSalaryComponentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/HrmSalaryComponent/HrmSalaryComponentIndex.cshtml");
        }
    }
}