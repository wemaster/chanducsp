namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblMail")]
    public partial class TblMail
    {
        [Key]
        public int IDMail { get; set; }

        [StringLength(50)]
        public string NameMail { get; set; }

        [StringLength(50)]
        public string atena { get; set; }

        [Column(TypeName = "text")]
        public string DetailMail { get; set; }

        public DateTime? DateSend { get; set; }

        public bool? Status { get; set; }
    }
}
