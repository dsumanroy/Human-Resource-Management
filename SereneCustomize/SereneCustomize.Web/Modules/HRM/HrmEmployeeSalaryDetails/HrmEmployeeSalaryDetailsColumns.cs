
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.HrmEmployeeSalaryDetails")]
    [BasedOnRow(typeof(Entities.HrmEmployeeSalaryDetailsRow), CheckNames = true)]
    public class HrmEmployeeSalaryDetailsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public Int32 EmployeeSalaryId { get; set; }
        public String EmployeeEmpId { get; set; }
        public String SalaryComponentName { get; set; }
        public Decimal Amount { get; set; }
    }
}