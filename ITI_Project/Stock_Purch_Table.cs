//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Purch_Table
    {
        public int Stock_Purch_ID { get; set; }
        public int Purchases_ID { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> Purch_Accept_States { get; set; }
        public Nullable<int> Deleted { get; set; }
    
        public virtual Product_Table Product_Table { get; set; }
        public virtual Purchases_Table Purchases_Table { get; set; }
    }
}