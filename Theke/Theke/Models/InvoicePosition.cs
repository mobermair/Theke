//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Theke.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoicePosition
    {
        public int InvoiceID { get; set; }
        public int PositionID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}