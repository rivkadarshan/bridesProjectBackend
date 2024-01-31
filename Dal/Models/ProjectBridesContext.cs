//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace Dal.Models;

//public partial class ProjectBridesContext : DbContext
//{
//    public ProjectBridesContext()
//    {
//    }

//    public ProjectBridesContext(DbContextOptions<ProjectBridesContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<BrideTbl> BrideTbls { get; set; }

//    public virtual DbSet<BridejewelryTbl> BridejewelryTbls { get; set; }

//    public virtual DbSet<JewelryTbl> JewelryTbls { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-N3PRKSF;Database=PROJECT_BRIDES;Trusted_Connection=true;TrustServerCertificate=True;");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<BrideTbl>(entity =>
//        {
//            entity.HasKey(e => e.Brideid).HasName("PK__BRIDE_TB__FDCE2C120EB647F7");

//            entity.ToTable("BRIDE_TBL");

//            entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
//            entity.Property(e => e.Brideinsertdate)
//                .HasColumnType("date")
//                .HasColumnName("BRIDEINSERTDATE");
//            entity.Property(e => e.Bridename)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasColumnName("BRIDENAME");
//            entity.Property(e => e.Bridephone).HasColumnName("BRIDEPHONE");
//            entity.Property(e => e.Debt).HasColumnName("DEBT");
//            entity.Property(e => e.DescriptionBride)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("DESCRIPTION_BRIDE");
//            entity.Property(e => e.Groomname)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasColumnName("GROOMNAME");
//            entity.Property(e => e.Groomphone).HasColumnName("GROOMPHONE");
//            entity.Property(e => e.Paid).HasColumnName("PAID");
//            entity.Property(e => e.Weddingdate)
//                .HasColumnType("date")
//                .HasColumnName("WEDDINGDATE");
//        });

//        modelBuilder.Entity<BridejewelryTbl>(entity =>
//        {
//            entity.HasKey(e => e.Bridejewelryid).HasName("PK__BRIDEJEW__3147CFF58788C04A");

//            entity.ToTable("BRIDEJEWELRY_TBL");

//            entity.Property(e => e.Bridejewelryid).HasColumnName("BRIDEJEWELRYID");
//            entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
//            entity.Property(e => e.Budget).HasColumnName("BUDGET");
//            entity.Property(e => e.Color)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("COLOR");
//            entity.Property(e => e.DescriptionBridejewelry)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("DESCRIPTION_BRIDEJEWELRY");
//            entity.Property(e => e.Jewelryid).HasColumnName("JEWELRYID");
//            entity.Property(e => e.Sumtopay).HasColumnName("SUMTOPAY");
//            entity.Property(e => e.Ischoose).HasColumnName("ISCHOOSE").HasColumnType("bit").IsRequired();
//            entity.Property(e => e.Jewelryname).HasMaxLength(30).IsUnicode(false).HasColumnName("JEWELRYNAME");
//            entity.HasOne(d => d.Bride).WithMany(p => p.BridejewelryTbls)
//                .HasForeignKey(d => d.Brideid)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK__BRIDEJEWE__BRIDE__29572725");

//            entity.HasOne(d => d.Jewelry).WithMany(p => p.BridejewelryTbls)
//                .HasForeignKey(d => d.Jewelryid)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK__BRIDEJEWE__JEWEL__286302EC");
//        });

//        modelBuilder.Entity<JewelryTbl>(entity =>
//        {
//            entity.HasKey(e => e.Jewelryid).HasName("PK__JEWELRY___B40793A7F16ED47E");

//            entity.ToTable("JEWELRY_TBL");

//            entity.Property(e => e.Jewelryid)
//                .ValueGeneratedNever()
//                .HasColumnName("JEWELRYID");
//            entity.Property(e => e.Feature)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("FEATURE");
//            entity.Property(e => e.Jewelryname)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasColumnName("JEWELRYNAME");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace Dal.Models
//{
//    public partial class ProjectBridesContext : DbContext
//    {
//        public ProjectBridesContext()
//        {
//        }

//        public ProjectBridesContext(DbContextOptions<ProjectBridesContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<BrideTbl> BrideTbls { get; set; }

//        public virtual DbSet<BridejewelryTbl> BridejewelryTbls { get; set; }

//        //public virtual DbSet<JewelryTbl> JewelryTbls { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//            => optionsBuilder.UseSqlServer("Server=DESKTOP-N3PRKSF;Database=PROJECT_BRIDES;Trusted_Connection=true;TrustServerCertificate=True;");

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<BrideTbl>(entity =>
//            {
//                entity.HasKey(e => e.Brideid).HasName("PK__BRIDE_TB__FDCE2C120EB647F7");

//                entity.ToTable("BRIDE_TBL");

//                entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
//                entity.Property(e => e.Brideinsertdate)
//                    .HasColumnType("date")
//                    .HasColumnName("BRIDEINSERTDATE");
//                entity.Property(e => e.Bridename)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("BRIDENAME");
//                entity.Property(e => e.Bridephone).HasColumnName("BRIDEPHONE");
//                entity.Property(e => e.Debt).HasColumnName("DEBT");
//                entity.Property(e => e.DescriptionBride)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DESCRIPTION_BRIDE");
//                entity.Property(e => e.Groomname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("GROOMNAME");
//                entity.Property(e => e.Groomphone).HasColumnName("GROOMPHONE");
//                entity.Property(e => e.Paid).HasColumnName("PAID");
//                entity.Property(e => e.Weddingdate)
//                    .HasColumnType("date")
//                    .HasColumnName("WEDDINGDATE");
//            });

//            modelBuilder.Entity<BridejewelryTbl>(entity =>
//            {
//                entity.HasKey(e => e.Bridejewelryid).HasName("PK__BRIDEJEW__3147CFF58788C04A");

//                entity.ToTable("BRIDEJEWELRY_TBL");

//                entity.Property(e => e.Bridejewelryid).HasColumnName("BRIDEJEWELRYID");
//                entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
//                entity.Property(e => e.Budget).HasColumnName("BUDGET");
//                entity.Property(e => e.Color)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("COLOR");
//                entity.Property(e => e.DescriptionBridejewelry)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("DESCRIPTION_BRIDEJEWELRY");
//                entity.Property(e => e.Jewelryid).HasColumnName("JEWELRYID");
//                entity.Property(e => e.Sumtopay).HasColumnName("SUMTOPAY");
//                entity.Property(e => e.Ischoose).HasColumnName("ISCHOOSE").HasColumnType("bit").IsRequired();
//                entity.Property(e => e.Jewelryname).HasMaxLength(30).IsUnicode(false).HasColumnName("JEWELRYNAME");

//                entity.HasOne(d => d.Bride).WithMany(p => p.BridejewelryTbls)
//                    .HasForeignKey(d => d.Brideid)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK__BRIDEJEWE__BRIDE__29572725");

//                // שינוי: הסרת קשר לטבלה JEWELRY_TBL
//                // entity.HasOne(d => d.Jewelry).WithMany(p => p.BridejewelryTbls)
//                //     .HasForeignKey(d => d.Jewelryid)
//                //     .OnDelete(DeleteBehavior.ClientSetNull)
//                //     .HasConstraintName("FK__BRIDEJEWE__JEWEL__286302EC");
//            });

//            modelBuilder.Entity<JewelryTbl>(entity =>
//            {
//                entity.HasKey(e => e.Jewelryid).HasName("PK__JEWELRY___B40793A7F16ED47E");

//                entity.ToTable("JEWELRY_TBL");

//                // שינוי: הסרת קשר מכל התייחסויות לטבלה JEWELRY_TBL
//                // modelBuilder.Entity<BridejewelryTbl>()
//                //     .HasOne(d => d.Jewelry)
//                //     .WithMany(p => p.BridejewelryTbls)
//                //     .HasForeignKey(d => d.Jewelryid)
//                //     .OnDelete(DeleteBehavior.ClientSetNull)
//                //     .HasConstraintName("FK__BRIDEJEWE__JEWEL__286302EC");

//                entity.Property(e => e.Jewelryid)
//                    .ValueGeneratedNever()
//                    .HasColumnName("JEWELRYID");
//                entity.Property(e => e.Feature)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("FEATURE");
//                entity.Property(e => e.Jewelryname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("JEWELRYNAME");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
using Microsoft.EntityFrameworkCore;

namespace Dal.Models
{
    public partial class ProjectBridesContext : DbContext
    {
        public ProjectBridesContext()
        {
        }

        public ProjectBridesContext(DbContextOptions<ProjectBridesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BrideTbl> BrideTbls { get; set; }
        public virtual DbSet<BridejewelryTbl> BridejewelryTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Server=DESKTOP-N3PRKSF;Database=PROJECT_BRIDES;Trusted_Connection=true;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrideTbl>(entity =>
            {
                entity.HasKey(e => e.Brideid).HasName("PK__BRIDE_TB__FDCE2C120EB647F7");

                entity.ToTable("BRIDE_TBL");

                entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
                entity.Property(e => e.Brideinsertdate)
                    .HasColumnType("date")
                    .HasColumnName("BRIDEINSERTDATE");
                entity.Property(e => e.Bridename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BRIDENAME");
                entity.Property(e => e.Bridephone).HasColumnName("BRIDEPHONE");
                entity.Property(e => e.Debt).HasColumnName("DEBT");
                entity.Property(e => e.DescriptionBride)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION_BRIDE");
                entity.Property(e => e.Groomname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GROOMNAME");
                entity.Property(e => e.Groomphone).HasColumnName("GROOMPHONE");
                entity.Property(e => e.Paid).HasColumnName("PAID");
                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Address");
                entity.Property(e => e.Weddingdate)
                    .HasColumnType("date")
                    .HasColumnName("WEDDINGDATE");
            });

            modelBuilder.Entity<BridejewelryTbl>(entity =>
            {
                entity.HasKey(e => e.Bridejewelryid).HasName("PK__BRIDEJEW__3147CFF58788C04A");

                entity.ToTable("BRIDEJEWELRY_TBL");

                entity.Property(e => e.Bridejewelryid).HasColumnName("BRIDEJEWELRYID");
                entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
                entity.Property(e => e.Budget).HasColumnName("BUDGET");
                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");
                entity.Property(e => e.DescriptionBridejewelry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION_BRIDEJEWELRY");
                entity.Property(e => e.Jewelryid).HasColumnName("JEWELRYID");
                entity.Property(e => e.Sumtopay).HasColumnName("SUMTOPAY");
                entity.Property(e => e.Ischoose).HasColumnName("ISCHOOSE").HasColumnType("bit").IsRequired();
                entity.Property(e => e.Jewelryname).HasMaxLength(30).IsUnicode(false).HasColumnName("JEWELRYNAME");

                entity.HasOne(d => d.Bride).WithMany(p => p.BridejewelryTbls)
                    .HasForeignKey(d => d.Brideid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BRIDEJEWE__BRIDE__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
