//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vluCanteenAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food1()
        {
            this.BillDetails = new HashSet<BillDetail>();
        }
    
        public int Food_ID { get; set; }
        public string Name { get; set; }
        public int Category_ID { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Remain { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<bool> isToday { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
