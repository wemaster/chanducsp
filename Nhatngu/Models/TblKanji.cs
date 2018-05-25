namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblKanji")]
    public partial class TblKanji
    {
        [Key]
        public int IDKanji { get; set; }

        [StringLength(250)]
        public string NameKanji { get; set; }

        [StringLength(250)]
        public string AmHan { get; set; }

        [StringLength(250)]
        public string Hiragana { get; set; }

        [StringLength(250)]
        public string YNghia { get; set; }

        [StringLength(250)]
        public string CachNho { get; set; }

        public bool? Status { get; set; }

        public DateTime? DayCreate { get; set; }
    }
}
