
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[HRM_SalaryTemplate]")]
    [DisplayName("Hrm Salary Template"), InstanceName("Hrm Salary Template")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class HrmSalaryTemplateRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Salary Grade"), Size(150), NotNull, QuickSearch]
        public String SalaryGrade
        {
            get { return Fields.SalaryGrade[this]; }
            set { Fields.SalaryGrade[this] = value; }
        }

        [DisplayName("Basic Salary"), Size(18), Scale(2)]
        public Decimal? BasicSalary
        {
            get { return Fields.BasicSalary[this]; }
            set { Fields.BasicSalary[this] = value; }
        }

        [DisplayName("Hourly Rate"), Size(8), Scale(2), NotNull]
        public Decimal? HourlyRate
        {
            get { return Fields.HourlyRate[this]; }
            set { Fields.HourlyRate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SalaryGrade; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public HrmSalaryTemplateRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SalaryGrade;
            public DecimalField BasicSalary;
            public DecimalField HourlyRate;
		}
    }
}
