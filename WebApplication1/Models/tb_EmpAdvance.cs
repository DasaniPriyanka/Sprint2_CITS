//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_EmpAdvance
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> ReceiptNo { get; set; }
        public string PaymentType { get; set; }
        public string GiveBy { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    
        public virtual tb_Employee tb_Employee { get; set; }
    }
}
