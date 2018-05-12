
namespace SereneCustomize.HRM.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HRM"), Module("HRM"), TableName("[dbo].[PRM_Designation]")]
    [DisplayName("Prm Designation"), InstanceName("Prm Designation")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PrmDesignationRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Short Name"), Size(50)]
        public String ShortName
        {
            get { return Fields.ShortName[this]; }
            set { Fields.ShortName[this] = value; }
        }

        [DisplayName("Sorting Order"), NotNull]
        public Int32? SortingOrder
        {
            get { return Fields.SortingOrder[this]; }
            set { Fields.SortingOrder[this] = value; }
        }

        [DisplayName("Remarks"), Size(500)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("I User"), Size(50), NotNull]
        public String IUser
        {
            get { return Fields.IUser[this]; }
            set { Fields.IUser[this] = value; }
        }

        [DisplayName("I Date"), NotNull]
        public DateTime? IDate
        {
            get { return Fields.IDate[this]; }
            set { Fields.IDate[this] = value; }
        }

        [DisplayName("E User"), Size(50)]
        public String EUser
        {
            get { return Fields.EUser[this]; }
            set { Fields.EUser[this] = value; }
        }

        [DisplayName("E Date")]
        public DateTime? EDate
        {
            get { return Fields.EDate[this]; }
            set { Fields.EDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PrmDesignationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField ShortName;
            public Int32Field SortingOrder;
            public StringField Remarks;
            public StringField IUser;
            public DateTimeField IDate;
            public StringField EUser;
            public DateTimeField EDate;
		}
    }
}
