
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.HrmSalaryProcess")]
    [BasedOnRow(typeof(Entities.HrmSalaryProcessRow), CheckNames = true)]
    public class HrmSalaryProcessColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String EmployeeEmpId { get; set; }
        public String SalaryTemplateSalaryGrade { get; set; }
        public Int32 Year { get; set; }
        [EditLink]
        public String Month { get; set; }
        public String YearMonth { get; set; }
    }
}