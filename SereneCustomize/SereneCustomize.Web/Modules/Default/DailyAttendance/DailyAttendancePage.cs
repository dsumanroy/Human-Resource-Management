
namespace SereneCustomize.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/DailyAttendance"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DailyAttendanceRow))]
    public class DailyAttendanceController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/DailyAttendance/DailyAttendanceIndex.cshtml");
        }
    }
}