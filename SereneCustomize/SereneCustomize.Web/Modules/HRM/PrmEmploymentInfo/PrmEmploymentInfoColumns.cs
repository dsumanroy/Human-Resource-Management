
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.PrmEmploymentInfo")]
    [BasedOnRow(typeof(Entities.PrmEmploymentInfoRow), CheckNames = true)]
    public class PrmEmploymentInfoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String DesignationName { get; set; }
        [EditLink]
        public String EmpId { get; set; }
        public String FullName { get; set; }
        public DateTime DateofJoining { get; set; }
        public String Gender { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}