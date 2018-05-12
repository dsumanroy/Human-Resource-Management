
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/HrmSalaryTemplateDetails"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HrmSalaryTemplateDetailsRow))]
    public class HrmSalaryTemplateDetailsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/HrmSalaryTemplateDetails/HrmSalaryTemplateDetailsIndex.cshtml");
        }
    }
}