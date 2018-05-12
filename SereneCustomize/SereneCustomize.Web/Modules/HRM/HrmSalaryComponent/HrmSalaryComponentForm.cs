
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.HrmSalaryComponent")]
    [BasedOnRow(typeof(Entities.HrmSalaryComponentRow), CheckNames = true)]
    public class HrmSalaryComponentForm
    {
        public String Name { get; set; }
    }
}