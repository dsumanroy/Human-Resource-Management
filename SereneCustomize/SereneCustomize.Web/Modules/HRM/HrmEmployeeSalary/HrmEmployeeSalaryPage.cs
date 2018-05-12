
namespace SereneCustomize.HRM.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HRM/HrmEmployeeSalary"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HrmEmployeeSalaryRow))]
    public class HrmEmployeeSalaryController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HRM/HrmEmployeeSalary/HrmEmployeeSalaryIndex.cshtml");
        }
    }
}