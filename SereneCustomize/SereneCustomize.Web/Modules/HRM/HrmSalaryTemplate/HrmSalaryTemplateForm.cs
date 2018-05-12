
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.HrmSalaryTemplate")]
    [BasedOnRow(typeof(Entities.HrmSalaryTemplateRow), CheckNames = true)]
    public class HrmSalaryTemplateForm
    {
        public String SalaryGrade { get; set; }
        public Decimal BasicSalary { get; set; }
        public Decimal HourlyRate { get; set; }
    }
}