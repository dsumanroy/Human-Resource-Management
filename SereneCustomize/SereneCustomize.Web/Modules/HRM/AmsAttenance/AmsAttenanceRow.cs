
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[AMS_Attenance]")]
    [DisplayName("Ams Attenance"), InstanceName("Ams Attenance")]
    [ReadPermission("*")]
    [ModifyPermission("*")]
    public sealed class AmsAttenanceRow : Row, IIdRow
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

        [DisplayName("Attendance Date"), NotNull]
        public DateTime? AttendanceDate
        {
            get { return Fields.AttendanceDate[this]; }
            set { Fields.AttendanceDate[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AmsAttenanceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field EmployeeId;
            public DateTimeField AttendanceDate;

            public Int32Field EmployeeDesignationId;
            public StringField EmployeeEmpId;
            public StringField EmployeeFullName;
            public DateTimeField EmployeeDateofJoining;
            public StringField EmployeeGender;
            public DateTimeField EmployeeDateofBirth;
		}
    }
}
