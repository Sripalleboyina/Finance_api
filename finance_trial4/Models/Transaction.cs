//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace finance_trial4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Transaction_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public System.DateTime Transction_date { get; set; }
        public Nullable<bool> Transaction_status { get; set; }
        public decimal Transaction_amount { get; set; }
    
        public virtual order order { get; set; }
    }
}