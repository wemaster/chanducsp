namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblCateChild")]
    public partial class TblCateChild
    {
        [Key]
        public int IDCateChild { get; set; }

        [StringLength(50)]
        public string NameCateChild { get; set; }

        public int? IDCate { get; set; }

        public bool? Status { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string SEOTitle { get; set; }
    }
}
