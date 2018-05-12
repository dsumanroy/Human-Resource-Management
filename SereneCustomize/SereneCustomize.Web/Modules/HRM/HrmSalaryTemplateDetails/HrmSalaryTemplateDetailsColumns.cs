
namespace SereneCustomize.HRM.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HRM.HrmSalaryTemplateDetails")]
    [BasedOnRow(typeof(Entities.HrmSalaryTemplateDetailsRow), CheckNames = true)]
    public class HrmSalaryTemplateDetailsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String SalaryTemplateSalaryGrade { get; set; }
        public String SalaryComponentName { get; set; }
        public Decimal ComponentAmount { get; set; }
    }
}