using Serenity.Navigation;
using MyPages = SereneCustomize.HRM.Pages;

[assembly: NavigationLink(int.MaxValue, "HRM/Ams Attenance", typeof(MyPages.AmsAttenanceController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Prm Designation", typeof(MyPages.PrmDesignationController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Prm Employment Info", typeof(MyPages.PrmEmploymentInfoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Hrm Employee Salary", typeof(MyPages.HrmEmployeeSalaryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Hrm Employee Salary Details", typeof(MyPages.HrmEmployeeSalaryDetailsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Hrm Salary Component", typeof(MyPages.HrmSalaryComponentController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Hrm Salary Process", typeof(MyPages.HrmSalaryProcessController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Hrm Salary Template", typeof(MyPages.HrmSalaryTemplateController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HRM/Hrm Salary Template Details", typeof(MyPages.HrmSalaryTemplateDetailsController), icon: null)]