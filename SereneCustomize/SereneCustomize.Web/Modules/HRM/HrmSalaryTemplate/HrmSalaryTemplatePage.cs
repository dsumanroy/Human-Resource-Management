
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/HrmSalaryTemplate"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HrmSalaryTemplateRow))]
    public class HrmSalaryTemplateController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/HrmSalaryTemplate/HrmSalaryTemplateIndex.cshtml");
        }
    }
}