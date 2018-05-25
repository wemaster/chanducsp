namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblCateParent")]
    public partial class TblCateParent
    {
        [Key]
        public int IDCate { get; set; }

        [StringLength(50)]
        public string Img { get; set; }

        [StringLength(50)]
        public string NameCate { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string SEOTitle { get; set; }

        [StringLength(250)]
        public string MetaKey { get; set; }

        public bool? Status { get; set; }
    }
}
