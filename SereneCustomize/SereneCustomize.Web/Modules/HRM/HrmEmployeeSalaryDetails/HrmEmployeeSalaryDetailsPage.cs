
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/HrmEmployeeSalaryDetails"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HrmEmployeeSalaryDetailsRow))]
    public class HrmEmployeeSalaryDetailsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/HrmEmployeeSalaryDetails/HrmEmployeeSalaryDetailsIndex.cshtml");
        }
    }
}