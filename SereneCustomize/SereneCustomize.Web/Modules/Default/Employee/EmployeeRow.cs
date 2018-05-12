
namespace SereneCustomize.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Users]")]
    [DisplayName("Employee"), InstanceName("Employee")]
    [ReadPermission("HRM:Employee:Read")]
    [InsertPermission("HRM:Employee:Insert")]
    [UpdatePermission("HRM:Employee:Update")]
    [DeletePermission("HRM:Employee:Delete")]
    public sealed class EmployeeRow : Row, IIdRow, INameRow
    {
        [DisplayName("User Id"), Identity]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("Username"), Size(100), NotNull, QuickSearch]
        public String Username
        {
            get { return Fields.Username[this]; }
            set { Fields.Username[this] = value; }
        }

        [DisplayName("Display Name"), Size(100), NotNull]
        public String DisplayName
        {
            get { return Fields.DisplayName[this]; }
            set { Fields.DisplayName[this] = value; }
        }

        [DisplayName("Email"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Source"), Size(4), NotNull]
        public String Source
        {
            get { return Fields.Source[this]; }
            set { Fields.Source[this] = value; }
        }

        [DisplayName("Password Hash"), Size(86), NotNull]
        public String PasswordHash
        {
            get { return Fields.PasswordHash[this]; }
            set { Fields.PasswordHash[this] = value; }
        }

        [DisplayName("Password Salt"), Size(10), NotNull]
        public String PasswordSalt
        {
            get { return Fields.PasswordSalt[this]; }
            set { Fields.PasswordSalt[this] = value; }
        }

        [DisplayName("Last Directory Update")]
        public DateTime? LastDirectoryUpdate
        {
            get { return Fields.LastDirectoryUpdate[this]; }
            set { Fields.LastDirectoryUpdate[this] = value; }
        }

        [DisplayName("User Image"), Size(100)]
        [ImageUploadEditor]
        public String UserImage
        {
            get { return Fields.UserImage[this]; }
            set { Fields.UserImage[this] = value; }
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Insert User Id"), NotNull]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Int16? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Designation"), ForeignKey("[dbo].[Designation]", "Id"), LeftJoin("jDesignation"), TextualField("DesignationName")]
        [LookupEditor(typeof(DesignationRow))]
        public Int64? DesignationId
        {
            get { return Fields.DesignationId[this]; }
            set { Fields.DesignationId[this] = value; }
        }

        [DisplayName("Birth Date"),DateTimeEditor]
        public DateTime? BirthDate
        {
            get { return Fields.BirthDate[this]; }
            set { Fields.BirthDate[this] = value; }
        }

        [DisplayName("Gender"), Size(255),NotNull]
        public String Gender
        {
            get { return Fields.Gender[this]; }
            set { Fields.Gender[this] = value; }
        }

        [DisplayName("Designation Name"), Expression("jDesignation.[Name]")]
        public String DesignationName
        {
            get { return Fields.DesignationName[this]; }
            set { Fields.DesignationName[this] = value; }
        }

        [DisplayName("Designation Remarks"), Expression("jDesignation.[Remarks]")]
        public String DesignationRemarks
        {
            get { return Fields.DesignationRemarks[this]; }
            set { Fields.DesignationRemarks[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.UserId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Username; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EmployeeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field UserId;
            public StringField Username;
            public StringField DisplayName;
            public StringField Email;
            public StringField Source;
            public StringField PasswordHash;
            public StringField PasswordSalt;
            public DateTimeField LastDirectoryUpdate;
            public StringField UserImage;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public Int16Field IsActive;
            public Int64Field DesignationId;
            public DateTimeField BirthDate;
            public StringField Gender;

            public StringField DesignationName;
            public StringField DesignationRemarks;
		}
    }
}
