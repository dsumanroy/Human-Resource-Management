
namespace SereneCustomize.HRM.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HRM.PrmDesignation")]
    [BasedOnRow(typeof(Entities.PrmDesignationRow), CheckNames = true)]
    public class PrmDesignationForm
    {
        public String Name { get; set; }
        public String ShortName { get; set; }
        public Int32 SortingOrder { get; set; }
        public String Remarks { get; set; }
        public String IUser { get; set; }
        public DateTime IDate { get; set; }
        public String EUser { get; set; }
        public DateTime EDate { get; set; }
    }
}