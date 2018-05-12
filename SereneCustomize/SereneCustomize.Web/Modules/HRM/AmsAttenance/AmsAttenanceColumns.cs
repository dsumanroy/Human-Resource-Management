
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.AmsAttenance")]
    [BasedOnRow(typeof(Entities.AmsAttenanceRow), CheckNames = true)]
    public class AmsAttenanceColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String EmployeeEmpId { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}