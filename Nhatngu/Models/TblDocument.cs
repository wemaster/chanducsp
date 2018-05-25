namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblDocument")]
    public partial class TblDocument
    {
        [Key]
        public int IDdocument { get; set; }

        [StringLength(50)]
        public string NameDocument { get; set; }

        [Column(TypeName = "text")]
        public string DetailDoc { get; set; }

        [StringLength(250)]
        public string LinkDown { get; set; }
    }
}
