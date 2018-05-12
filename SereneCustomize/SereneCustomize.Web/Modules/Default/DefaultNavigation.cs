using Serenity.Navigation;
using MyPages = SereneCustomize.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Daily Attendance", typeof(MyPages.DailyAttendanceController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Designation", typeof(MyPages.DesignationController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Employee", typeof(MyPages.EmployeeController), icon: null)]