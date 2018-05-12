
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.HrmEmployeeSalaryDetails")]
    [BasedOnRow(typeof(Entities.HrmEmployeeSalaryDetailsRow), CheckNames = true)]
    public class HrmEmployeeSalaryDetailsForm
    {
        public Int32 EmployeeSalaryId { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 SalaryComponentId { get; set; }
        public Decimal Amount { get; set; }
    }
}