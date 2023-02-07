//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBanhang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.CTHDs = new HashSet<CTHD>();
        }
    
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public Nullable<int> MaNV { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime NgayLapHD { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime NgayGiaoHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
    }
}
