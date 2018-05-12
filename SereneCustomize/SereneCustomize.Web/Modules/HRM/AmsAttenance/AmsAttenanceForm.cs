
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.AmsAttenance")]
    [BasedOnRow(typeof(Entities.AmsAttenanceRow), CheckNames = true)]
    public class AmsAttenanceForm
    {
        public Int32 EmployeeId { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}