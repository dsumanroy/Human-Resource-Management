
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.HrmSalaryProcess")]
    [BasedOnRow(typeof(Entities.HrmSalaryProcessRow), CheckNames = true)]
    public class HrmSalaryProcessForm
    {
        public Int32 EmployeeId { get; set; }
        public Int32 SalaryTemplateId { get; set; }
        public Int32 Year { get; set; }
        public String Month { get; set; }
        public String YearMonth { get; set; }
    }
}