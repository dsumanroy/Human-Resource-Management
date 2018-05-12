
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[HRM_EmployeeSalaryDetails]")]
    [DisplayName("Hrm Employee Salary Details"), InstanceName("Hrm Employee Salary Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class HrmEmployeeSalaryDetailsRow : Row, IIdRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Employee Salary"), NotNull, ForeignKey("[dbo].[HRM_EmployeeSalary]", "Id"), LeftJoin("jEmployeeSalary")]
        public Int32? EmployeeSalaryId
        {
            get { return Fields.EmployeeSalaryId[this]; }
            set { Fields.EmployeeSalaryId[this] = value; }
        }

        [DisplayName("Employee"), NotNull, ForeignKey("[dbo].[PRM_EmploymentInfo]", "Id"), LeftJoin("jEmployee"), TextualField("EmployeeEmpId")]
        public Int32? EmployeeId
        {
            get { return Fields.EmployeeId[this]; }
            set { Fields.EmployeeId[this] = value; }
        }

        [DisplayName("Salary Component"), NotNull, ForeignKey("[dbo].[HRM_SalaryComponent]", "Id"), LeftJoin("jSalaryComponent"), TextualField("SalaryComponentName")]
        public Int32? SalaryComponentId
        {
            get { return Fields.SalaryComponentId[this]; }
            set { Fields.SalaryComponentId[this] = value; }
        }

        [DisplayName("Amount"), Size(8), Scale(2), NotNull]
        public Decimal? Amount
        {
            get { return Fields.Amount[this]; }
            set { Fields.Amount[this] = value; }
        }

        [DisplayName("Employee Salary Employee Id"), Expression("jEmployeeSalary.[EmployeeId]")]
        public Int32? EmployeeSalaryEmployeeId
        {
            get { return Fields.EmployeeSalaryEmployeeId[this]; }
            set { Fields.EmployeeSalaryEmployeeId[this] = value; }
        }

        [DisplayName("Employee Salary Salary Template Id"), Expression("jEmployeeSalary.[SalaryTemplateId]")]
        public Int32? EmployeeSalarySalaryTemplateId
        {
            get { return Fields.EmployeeSalarySalaryTemplateId[this]; }
            set { Fields.EmployeeSalarySalaryTemplateId[this] = value; }
        }

        [DisplayName("Employee Salary Basic Salary"), Expression("jEmployeeSalary.[BasicSalary]")]
        public Decimal? EmployeeSalaryBasicSalary
        {
            get { return Fields.EmployeeSalaryBasicSalary[this]; }
            set { Fields.EmployeeSalaryBasicSalary[this] = value; }
        }

        [DisplayName("Employee Salary Hourly Rate"), Expression("jEmployeeSalary.[HourlyRate]")]
        public Decimal? EmployeeSalaryHourlyRate
        {
            get { return Fields.EmployeeSalaryHourlyRate[this]; }
            set { Fields.EmployeeSalaryHourlyRate[this] = value; }
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

        [DisplayName("Salary Component Name"), Expression("jSalaryComponent.[Name]")]
        public String SalaryComponentName
        {
            get { return Fields.SalaryComponentName[this]; }
            set { Fields.SalaryComponentName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public HrmEmployeeSalaryDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field EmployeeSalaryId;
            public Int32Field EmployeeId;
            public Int32Field SalaryComponentId;
            public DecimalField Amount;

            public Int32Field EmployeeSalaryEmployeeId;
            public Int32Field EmployeeSalarySalaryTemplateId;
            public DecimalField EmployeeSalaryBasicSalary;
            public DecimalField EmployeeSalaryHourlyRate;

            public Int32Field EmployeeDesignationId;
            public StringField EmployeeEmpId;
            public StringField EmployeeFullName;
            public DateTimeField EmployeeDateofJoining;
            public StringField EmployeeGender;
            public DateTimeField EmployeeDateofBirth;

            public StringField SalaryComponentName;
		}
    }
}
