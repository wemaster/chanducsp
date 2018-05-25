namespace Nhatngu.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NihongoDBContext : DbContext
    {
        public NihongoDBContext()
            : base("name=NihongoDBContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TblAcc> TblAccs { get; set; }
        public virtual DbSet<TblCateChild> TblCateChilds { get; set; }
        public virtual DbSet<TblCateParent> TblCateParents { get; set; }
        public virtual DbSet<TblDocument> TblDocuments { get; set; }
        public virtual DbSet<TblKanji> TblKanjis { get; set; }
        public virtual DbSet<TblMail> TblMails { get; set; }
        public virtual DbSet<TblNew> TblNews { get; set; }
        public virtual DbSet<TblPer> TblPers { get; set; }
        public virtual DbSet<TblTest> TblTests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAcc>()
                .Property(e => e.NumberTest)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TblDocument>()
                .Property(e => e.DetailDoc)
                .IsUnicode(false);

            modelBuilder.Entity<TblMail>()
                .Property(e => e.DetailMail)
                .IsUnicode(false);

            modelBuilder.Entity<TblNew>()
                .Property(e => e.DetailNews)
                .IsUnicode(false);

            modelBuilder.Entity<TblNew>()
                .Property(e => e.LinkVideo)
                .IsFixedLength();
        }
    }
}
