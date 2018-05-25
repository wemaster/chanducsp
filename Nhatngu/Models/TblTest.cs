namespace Nhatngu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTest")]
    public partial class TblTest
    {
        [Key]
        public int IDTest { get; set; }

        public int? IDCate { get; set; }

        [StringLength(250)]
        public string NameTest { get; set; }

        [StringLength(50)]
        public string TestA { get; set; }

        [StringLength(50)]
        public string TestB { get; set; }

        [StringLength(50)]
        public string TestC { get; set; }

        [StringLength(50)]
        public string TestD { get; set; }

        [StringLength(50)]
        public string TestTrue { get; set; }

        public bool? Status { get; set; }

        public DateTime? DateCreate { get; set; }

    }
}
