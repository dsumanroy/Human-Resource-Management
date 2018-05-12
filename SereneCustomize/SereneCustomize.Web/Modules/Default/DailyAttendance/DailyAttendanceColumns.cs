
namespace SereneCustomize.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.DailyAttendance")]
    [BasedOnRow(typeof(Entities.DailyAttendanceRow), CheckNames = true)]
    public class DailyAttendanceColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String UserUsername { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}