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
    
    public partial class DailyFood
    {
        public int Dailyfood_ID { get; set; }
        public Nullable<int> Food_ID { get; set; }
        public Nullable<bool> isToday { get; set; }
    
        public virtual Food1 Food1 { get; set; }
    }
}