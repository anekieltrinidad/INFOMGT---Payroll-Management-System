//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayrollSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalariesAudit
    {
        public int LogID { get; set; }
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; }
        public string ActionType { get; set; }
        public string MadeBy { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Application { get; set; }
    }
}
