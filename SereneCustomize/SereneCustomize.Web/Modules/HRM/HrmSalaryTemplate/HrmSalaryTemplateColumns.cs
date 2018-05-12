
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.HrmSalaryTemplate")]
    [BasedOnRow(typeof(Entities.HrmSalaryTemplateRow), CheckNames = true)]
    public class HrmSalaryTemplateColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String SalaryGrade { get; set; }
        public Decimal BasicSalary { get; set; }
        public Decimal HourlyRate { get; set; }
    }
}