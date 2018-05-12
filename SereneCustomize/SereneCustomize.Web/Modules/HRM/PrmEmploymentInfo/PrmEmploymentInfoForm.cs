
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.PrmEmploymentInfo")]
    [BasedOnRow(typeof(Entities.PrmEmploymentInfoRow), CheckNames = true)]
    public class PrmEmploymentInfoForm
    {
        public Int32 DesignationId { get; set; }
        public String EmpId { get; set; }
        public String FullName { get; set; }
        public DateTime DateofJoining { get; set; }
        public String Gender { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}