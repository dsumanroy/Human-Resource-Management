
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[HRM_SalaryTemplateDetails]")]
    [DisplayName("Hrm Salary Template Details"), InstanceName("Hrm Salary Template Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class HrmSalaryTemplateDetailsRow : Row, IIdRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Salary Template"), NotNull, ForeignKey("[dbo].[HRM_SalaryTemplate]", "Id"), LeftJoin("jSalaryTemplate"), TextualField("SalaryTemplateSalaryGrade")]
        public Int32? SalaryTemplateId
        {
            get { return Fields.SalaryTemplateId[this]; }
            set { Fields.SalaryTemplateId[this] = value; }
        }

        [DisplayName("Salary Component"), NotNull, ForeignKey("[dbo].[HRM_SalaryComponent]", "Id"), LeftJoin("jSalaryComponent"), TextualField("SalaryComponentName")]
        public Int32? SalaryComponentId
        {
            get { return Fields.SalaryComponentId[this]; }
            set { Fields.SalaryComponentId[this] = value; }
        }

        [DisplayName("Component Amount"), Size(8), Scale(2), NotNull]
        public Decimal? ComponentAmount
        {
            get { return Fields.ComponentAmount[this]; }
            set { Fields.ComponentAmount[this] = value; }
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

        public HrmSalaryTemplateDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field SalaryTemplateId;
            public Int32Field SalaryComponentId;
            public DecimalField ComponentAmount;

            public StringField SalaryTemplateSalaryGrade;
            public DecimalField SalaryTemplateBasicSalary;
            public DecimalField SalaryTemplateHourlyRate;

            public StringField SalaryComponentName;
		}
    }
}
