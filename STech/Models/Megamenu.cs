//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Megamenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Megamenu()
        {
            this.MegamenuItems = new HashSet<MegamenuItem>();
        }
    
        public int Id { get; set; }
        public string MegamenuName { get; set; }
        public string MegamenuLink { get; set; }
        public int SidebarItemId { get; set; }
    
        public virtual SidebarMenu SidebarMenu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MegamenuItem> MegamenuItems { get; set; }
    }
}