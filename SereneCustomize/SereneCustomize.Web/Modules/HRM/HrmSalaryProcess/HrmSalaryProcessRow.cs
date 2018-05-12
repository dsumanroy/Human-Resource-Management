
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[HRM_SalaryProcess]")]
    [DisplayName("Hrm Salary Process"), InstanceName("Hrm Salary Process")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class HrmSalaryProcessRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Employee"), NotNull, ForeignKey("[dbo].[PRM_EmploymentInfo]", "Id"), LeftJoin("jEmployee"), TextualField("EmployeeEmpId")]
        public Int32? EmployeeId
        {
            get { return Fields.EmployeeId[this]; }
            set { Fields.EmployeeId[this] = value; }
        }

        [DisplayName("Salary Template"), NotNull, ForeignKey("[dbo].[HRM_SalaryTemplate]", "Id"), LeftJoin("jSalaryTemplate"), TextualField("SalaryTemplateSalaryGrade")]
        public Int32? SalaryTemplateId
        {
            get { return Fields.SalaryTemplateId[this]; }
            set { Fields.SalaryTemplateId[this] = value; }
        }

        [DisplayName("Year"), NotNull]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Month"), Size(50), NotNull, QuickSearch]
        public String Month
        {
            get { return Fields.Month[this]; }
            set { Fields.Month[this] = value; }
        }

        [DisplayName("Year Month"), Size(50), NotNull]
        public String YearMonth
        {
            get { return Fields.YearMonth[this]; }
            set { Fields.YearMonth[this] = value; }
        }

        [DisplayName("Employee Designation Id"), Expression("jEmployee.[DesignationId]")]
        public Int32? EmployeeDesignationId
        {
            get { return Fields.EmployeeDesignationId[this]; }
            set { Fields.EmployeeDesignationId[this] = value; }
        }

        [DisplayName("Employee Emp Id"), Expression("jEmployee.[EmpID]")]
        public String EmployeeEmpId
        {
            get { return Fields.EmployeeEmpId[this]; }
            set { Fields.EmployeeEmpId[this] = value; }
        }

        [DisplayName("Employee Full Name"), Expression("jEmployee.[FullName]")]
        public String EmployeeFullName
        {
            get { return Fields.EmployeeFullName[this]; }
            set { Fields.EmployeeFullName[this] = value; }
        }

        [DisplayName("Employee Dateof Joining"), Expression("jEmployee.[DateofJoining]")]
        public DateTime? EmployeeDateofJoining
        {
            get { return Fields.EmployeeDateofJoining[this]; }
            set { Fields.EmployeeDateofJoining[this] = value; }
        }

        [DisplayName("Employee Gender"), Expression("jEmployee.[Gender]")]
        public String EmployeeGender
        {
            get { return Fields.EmployeeGender[this]; }
            set { Fields.EmployeeGender[this] = value; }
        }

        [DisplayName("Employee Dateof Birth"), Expression("jEmployee.[DateofBirth]")]
        public DateTime? EmployeeDateofBirth
        {
            get { return Fields.EmployeeDateofBirth[this]; }
            set { Fields.EmployeeDateofBirth[this] = value; }
        }

        [DisplayName("Salary Template Salary Grade"), Expression("jSalaryTemplate.[SalaryGrade]")]
        public String SalaryTemplateSalaryGrade
        {
            get { return Fields.SalaryTemplateSalaryGrade[this]; }
            set { Fields.SalaryTemplateSalaryGrade[this] = value; }
        }

        [DisplayName("Salary Template Basic Salary"), Expression("jSalaryTemplate.[BasicSalary]")]
        public Decimal? SalaryTemplateBasicSalary
        {
            get { return Fields.SalaryTemplateBasicSalary[this]; }
            set { Fields.SalaryTemplateBasicSalary[this] = value; }
        }

        [DisplayName("Salary Template Hourly Rate"), Expression("jSalaryTemplate.[HourlyRate]")]
        public Decimal? SalaryTemplateHourlyRate
        {
            get { return Fields.SalaryTemplateHourlyRate[this]; }
            set { Fields.SalaryTemplateHourlyRate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Month; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public HrmSalaryProcessRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field EmployeeId;
            public Int32Field SalaryTemplateId;
            public Int32Field Year;
            public StringField Month;
            public StringField YearMonth;

            public Int32Field EmployeeDesignationId;
            public StringField EmployeeEmpId;
            public StringField EmployeeFullName;
            public DateTimeField EmployeeDateofJoining;
            public StringField EmployeeGender;
            public DateTimeField EmployeeDateofBirth;

            public StringField SalaryTemplateSalaryGrade;
            public DecimalField SalaryTemplateBasicSalary;
            public DecimalField SalaryTemplateHourlyRate;
		}
    }
}
