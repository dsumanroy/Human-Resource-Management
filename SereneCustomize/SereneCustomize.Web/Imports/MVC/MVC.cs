using System;

namespace MVC
{
    public static class Views
    {
        public static class Administration
        {
            public static class Language
            {
                public const string LanguageIndex = "~/Modules/Administration/Language/LanguageIndex.cshtml";
            }

            public static class Role
            {
                public const string RoleIndex = "~/Modules/Administration/Role/RoleIndex.cshtml";
            }

            public static class Translation
            {
                public const string TranslationIndex = "~/Modules/Administration/Translation/TranslationIndex.cshtml";
            }

            public static class User
            {
                public const string UserIndex = "~/Modules/Administration/User/UserIndex.cshtml";
            }

        }

        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }

            public static class Reporting
            {
                public const string ReportPage = "~/Modules/Common/Reporting/ReportPage.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class HRM
        {
            public static class AmsAttenance
            {
                public const string AmsAttenanceIndex = "~/Modules/HRM/AmsAttenance/AmsAttenanceIndex.cshtml";
            }

            public static class HrmEmployeeSalary
            {
                public const string HrmEmployeeSalaryIndex = "~/Modules/HRM/HrmEmployeeSalary/HrmEmployeeSalaryIndex.cshtml";
            }

            public static class HrmEmployeeSalaryDetails
            {
                public const string HrmEmployeeSalaryDetailsIndex = "~/Modules/HRM/HrmEmployeeSalaryDetails/HrmEmployeeSalaryDetailsIndex.cshtml";
            }

            public static class HrmSalaryComponent
            {
                public const string HrmSalaryComponentIndex = "~/Modules/HRM/HrmSalaryComponent/HrmSalaryComponentIndex.cshtml";
            }

            public static class HrmSalaryProcess
            {
                public const string HrmSalaryProcessIndex = "~/Modules/HRM/HrmSalaryProcess/HrmSalaryProcessIndex.cshtml";
            }

            public static class HrmSalaryTemplate
            {
                public const string HrmSalaryTemplateIndex = "~/Modules/HRM/HrmSalaryTemplate/HrmSalaryTemplateIndex.cshtml";
            }

            public static class HrmSalaryTemplateDetails
            {
                public const string HrmSalaryTemplateDetailsIndex = "~/Modules/HRM/HrmSalaryTemplateDetails/HrmSalaryTemplateDetailsIndex.cshtml";
            }

            public static class PrmDesignation
            {
                public const string PrmDesignationIndex = "~/Modules/HRM/PrmDesignation/PrmDesignationIndex.cshtml";
            }

            public static class PrmEmploymentInfo
            {
                public const string PrmEmploymentInfoIndex = "~/Modules/HRM/PrmEmploymentInfo/PrmEmploymentInfoIndex.cshtml";
            }

        }

        public static class Membership
        {
            public static class Account
            {
                public const string AccountLogin = "~/Modules/Membership/Account/AccountLogin.cshtml";
                public const string AccountLogin_AdminLTE = "~/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml";
                public static class ChangePassword
                {
                    public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
                    public const string AccountForgotPassword_AdminLTE = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml";
                }

                public static class ResetPassword
                {
                    public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
                    public const string AccountResetPassword_AdminLTE = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml";
                    public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
                }

                public static class SignUp
                {
                    public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
                    public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
                    public const string AccountSignUp_AdminLTE = "~/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml";
                }
            }
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _LayoutSlim = "~/Views/Shared/_LayoutSlim.cshtml";
            public const string _LayoutSlimHead = "~/Views/Shared/_LayoutSlimHead.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
            public const string LeftNavigation = "~/Views/Shared/LeftNavigation.cshtml";
        }
    }
}

