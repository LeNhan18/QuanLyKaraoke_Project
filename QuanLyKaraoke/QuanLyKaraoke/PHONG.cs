//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKaraoke
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            this.HOA_DON_BAN_HANG = new HashSet<HOA_DON_BAN_HANG>();
        }
    
        public string IDPhong { get; set; }
        public string TenPhong { get; set; }
        public Nullable<int> IDLoaiPhong { get; set; }
        public Nullable<byte> TrangThai { get; set; }
        public Nullable<int> SucChua { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON_BAN_HANG> HOA_DON_BAN_HANG { get; set; }
        public virtual LOAI_PHONG LOAI_PHONG { get; set; }
    }
}
