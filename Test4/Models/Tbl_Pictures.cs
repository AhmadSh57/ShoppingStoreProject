//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Pictures
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Pictures()
        {
            this.Tbl_ProductImage = new HashSet<Tbl_ProductImage>();
            this.Tbl_MainCategory_Image = new HashSet<Tbl_MainCategory_Image>();
            this.Tbl_SubTitle_image = new HashSet<Tbl_SubTitle_image>();
        }
    
        public int PicId { get; set; }
        public string PicName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ProductImage> Tbl_ProductImage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_MainCategory_Image> Tbl_MainCategory_Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SubTitle_image> Tbl_SubTitle_image { get; set; }
    }
}
