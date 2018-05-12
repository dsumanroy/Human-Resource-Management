
namespace SereneCustomize.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.DailyAttendance")]
    [BasedOnRow(typeof(Entities.DailyAttendanceRow), CheckNames = true)]
    public class DailyAttendanceForm
    {
        public Int32 UserId { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}