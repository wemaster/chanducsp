namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblNew")]
    public partial class TblNew
    {
        [Key]
        public int IDNews { get; set; }

        [StringLength(50)]
        public string NameCate { get; set; }

        public int? IDNewcate { get; set; }

        [StringLength(250)]
        public string NameNews { get; set; }

        [StringLength(50)]
        public string ImgIcon { get; set; }

        [StringLength(50)]
        public string NameUser { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime? DayCreate { get; set; }

        [Column(TypeName = "text")]
        public string DetailNews { get; set; }

        [StringLength(50)]
        public string Img1 { get; set; }

        [StringLength(50)]
        public string Img2 { get; set; }

        [StringLength(50)]
        public string Img3 { get; set; }

        [StringLength(50)]
        public string Img4 { get; set; }

        [StringLength(50)]
        public string Img5 { get; set; }

        [StringLength(50)]
        public string Img6 { get; set; }

        [StringLength(10)]
        public string LinkVideo { get; set; }

        public int? CountView { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string MetaKeyword { get; set; }

        public bool? Status { get; set; }

       
        
    }
}
