
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.HrmEmployeeSalary")]
    [BasedOnRow(typeof(Entities.HrmEmployeeSalaryRow), CheckNames = true)]
    public class HrmEmployeeSalaryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String EmployeeEmpId { get; set; }
        public String SalaryTemplateSalaryGrade { get; set; }
        public Decimal BasicSalary { get; set; }
        public Decimal HourlyRate { get; set; }
    }
}