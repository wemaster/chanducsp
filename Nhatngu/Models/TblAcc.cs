namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblAcc")]
    public partial class TblAcc
    {
        [Key]
        public int IdAcc { get; set; }

        [Required(ErrorMessage="Vui lòng điền tên đăng nhập")]
        [Display(Name="Tên đăng nhập")]
        [StringLength(50)]
        public string NameAcc { get; set; }

        [StringLength(250)]
        public string NameView { get; set; }

        [Display(Name="Mật khẩu")]
        [Required(ErrorMessage="Vui lòng điền mật khẩu")]
        [StringLength(50)]
        public string PassAcc { get; set; }

        public int? IDPer { get; set; }

        public DateTime? DayReg { get; set; }

        public decimal? NumberTest { get; set; }

        [StringLength(250)]
        public string Img { get; set; }

        public virtual TblPer peracc { get; set; }
    }
}
