
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.HrmEmployeeSalary")]
    [BasedOnRow(typeof(Entities.HrmEmployeeSalaryRow), CheckNames = true)]
    public class HrmEmployeeSalaryForm
    {
        public Int32 EmployeeId { get; set; }
        public Int32 SalaryTemplateId { get; set; }
        public Decimal BasicSalary { get; set; }
        public Decimal HourlyRate { get; set; }
    }
}