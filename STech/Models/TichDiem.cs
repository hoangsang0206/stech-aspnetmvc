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
    
    public partial class TichDiem
    {
        public string MaTD { get; set; }
        public Nullable<System.DateTime> NgayTD { get; set; }
        public decimal SoDiem { get; set; }
        public string TrangThai { get; set; }
        public string MaThe { get; set; }
        public string MaHD { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual TheThanhVien TheThanhVien { get; set; }
    }
}