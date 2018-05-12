
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[PRM_EmploymentInfo]")]
    [DisplayName("Prm Employment Info"), InstanceName("Prm Employment Info")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PrmEmploymentInfoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Designation"), NotNull, ForeignKey("[dbo].[PRM_Designation]", "Id"), LeftJoin("jDesignation"), TextualField("DesignationName")]
        public Int32? DesignationId
        {
            get { return Fields.DesignationId[this]; }
            set { Fields.DesignationId[this] = value; }
        }

        [DisplayName("Emp Id"), Column("EmpID"), Size(15), NotNull, QuickSearch]
        public String EmpId
        {
            get { return Fields.EmpId[this]; }
            set { Fields.EmpId[this] = value; }
        }

        [DisplayName("Full Name"), Size(200), NotNull]
        public String FullName
        {
            get { return Fields.FullName[this]; }
            set { Fields.FullName[this] = value; }
        }

        [DisplayName("Dateof Joining"), NotNull]
        public DateTime? DateofJoining
        {
            get { return Fields.DateofJoining[this]; }
            set { Fields.DateofJoining[this] = value; }
        }

        [DisplayName("Gender"), Size(20), NotNull]
        public String Gender
        {
            get { return Fields.Gender[this]; }
            set { Fields.Gender[this] = value; }
        }

        [DisplayName("Dateof Birth"), NotNull]
        public DateTime? DateofBirth
        {
            get { return Fields.DateofBirth[this]; }
            set { Fields.DateofBirth[this] = value; }
        }

        [DisplayName("Designation Name"), Expression("jDesignation.[Name]")]
        public String DesignationName
        {
            get { return Fields.DesignationName[this]; }
            set { Fields.DesignationName[this] = value; }
        }

        [DisplayName("Designation Short Name"), Expression("jDesignation.[ShortName]")]
        public String DesignationShortName
        {
            get { return Fields.DesignationShortName[this]; }
            set { Fields.DesignationShortName[this] = value; }
        }

        [DisplayName("Designation Sorting Order"), Expression("jDesignation.[SortingOrder]")]
        public Int32? DesignationSortingOrder
        {
            get { return Fields.DesignationSortingOrder[this]; }
            set { Fields.DesignationSortingOrder[this] = value; }
        }

        [DisplayName("Designation Remarks"), Expression("jDesignation.[Remarks]")]
        public String DesignationRemarks
        {
            get { return Fields.DesignationRemarks[this]; }
            set { Fields.DesignationRemarks[this] = value; }
        }

        [DisplayName("Designation I User"), Expression("jDesignation.[IUser]")]
        public String DesignationIUser
        {
            get { return Fields.DesignationIUser[this]; }
            set { Fields.DesignationIUser[this] = value; }
        }

        [DisplayName("Designation I Date"), Expression("jDesignation.[IDate]")]
        public DateTime? DesignationIDate
        {
            get { return Fields.DesignationIDate[this]; }
            set { Fields.DesignationIDate[this] = value; }
        }

        [DisplayName("Designation E User"), Expression("jDesignation.[EUser]")]
        public String DesignationEUser
        {
            get { return Fields.DesignationEUser[this]; }
            set { Fields.DesignationEUser[this] = value; }
        }

        [DisplayName("Designation E Date"), Expression("jDesignation.[EDate]")]
        public DateTime? DesignationEDate
        {
            get { return Fields.DesignationEDate[this]; }
            set { Fields.DesignationEDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EmpId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PrmEmploymentInfoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field DesignationId;
            public StringField EmpId;
            public StringField FullName;
            public DateTimeField DateofJoining;
            public StringField Gender;
            public DateTimeField DateofBirth;

            public StringField DesignationName;
            public StringField DesignationShortName;
            public Int32Field DesignationSortingOrder;
            public StringField DesignationRemarks;
            public StringField DesignationIUser;
            public DateTimeField DesignationIDate;
            public StringField DesignationEUser;
            public DateTimeField DesignationEDate;
		}
    }
}
