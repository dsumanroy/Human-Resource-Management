
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.HrmSalaryTemplateDetails")]
    [BasedOnRow(typeof(Entities.HrmSalaryTemplateDetailsRow), CheckNames = true)]
    public class HrmSalaryTemplateDetailsForm
    {
        public Int32 SalaryTemplateId { get; set; }
        public Int32 SalaryComponentId { get; set; }
        public Decimal ComponentAmount { get; set; }
    }
}