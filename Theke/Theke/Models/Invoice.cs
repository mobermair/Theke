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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InvoicePosition = new HashSet<InvoicePosition>();
        }
    
        public int InvoiceID { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public Nullable<int> InvoiceAddressID { get; set; }
        public Nullable<byte> Storno { get; set; }
    
        public virtual InvoiceAddress InvoiceAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicePosition> InvoicePosition { get; set; }
    }
}
