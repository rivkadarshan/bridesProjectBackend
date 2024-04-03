
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
//                entity.Property(e => e.Address)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("Address");
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
        public virtual DbSet<Correction> Corrections { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N3PRKSF;Database=PROJECT_BRIDES;Trusted_Connection=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrideTbl>(entity =>
            {
                entity.HasKey(e => e.Brideid).HasName("PK__BRIDE_TB__FDCE2C120EB647F7");
                entity.ToTable("BRIDE_TBL");
                entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
                entity.Property(e => e.Brideinsertdate).HasColumnType("date").HasColumnName("BRIDEINSERTDATE");
                entity.Property(e => e.Bridename).HasMaxLength(30).IsUnicode(false).HasColumnName("BRIDENAME");
                entity.Property(e => e.Bridephone).HasColumnName("BRIDEPHONE");
                entity.Property(e => e.Debt).HasColumnName("DEBT");
                entity.Property(e => e.DescriptionBride).HasMaxLength(50).IsUnicode(false).HasColumnName("DESCRIPTION_BRIDE");
                entity.Property(e => e.Groomname).HasMaxLength(30).IsUnicode(false).HasColumnName("GROOMNAME");
                entity.Property(e => e.Groomphone).HasColumnName("GROOMPHONE");
                entity.Property(e => e.Paid).HasColumnName("PAID");
                entity.Property(e => e.Address).HasMaxLength(50).IsUnicode(false).HasColumnName("Address");
                entity.Property(e => e.Weddingdate).HasColumnType("date").HasColumnName("WEDDINGDATE");
            });

            modelBuilder.Entity<BridejewelryTbl>(entity =>
            {
                entity.HasKey(e => e.Bridejewelryid).HasName("PK__BRIDEJEW__3147CFF58788C04A");
                entity.ToTable("BRIDEJEWELRY_TBL");
                entity.Property(e => e.Bridejewelryid).HasColumnName("BRIDEJEWELRYID");
                entity.Property(e => e.Brideid).HasColumnName("BRIDEID");
                entity.Property(e => e.Budget).HasColumnName("BUDGET");
                entity.Property(e => e.Color).HasMaxLength(20).IsUnicode(false).HasColumnName("COLOR");
                entity.Property(e => e.DescriptionBridejewelry).HasMaxLength(50).IsUnicode(false).HasColumnName("DESCRIPTION_BRIDEJEWELRY");
                entity.Property(e => e.Jewelryid).HasColumnName("JEWELRYID");
                entity.Property(e => e.Sumtopay).HasColumnName("SUMTOPAY");
                entity.Property(e => e.Ischoose).HasColumnName("ISCHOOSE").HasColumnType("bit").IsRequired();
                entity.Property(e => e.Jewelryname).HasMaxLength(30).IsUnicode(false).HasColumnName("JEWELRYNAME");
                entity.HasOne(d => d.Bride).WithMany(p => p.BridejewelryTbls).HasForeignKey(d => d.Brideid).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__BRIDEJEWE__BRIDE__29572725");
            });

            modelBuilder.Entity<Correction>(entity =>
            {
                entity.ToTable("CORRECTION");
                entity.Property(e => e.CorrectionId).HasColumnName("CORRECTION_ID");
                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
                entity.Property(e => e.EmployeeIdTakeCorrections).HasColumnName("EMPLOYEE_ID_TAKE_CORRECTIONS");
                entity.Property(e => e.EmployeeIdDeliverMessage).HasColumnName("EMPLOYEE_ID_DELIVER_MESSAGE");
                entity.Property(e => e.ReceivingDate).HasColumnName("RECEIVING_DATE");
                entity.Property(e => e.GoldsmithId).HasColumnName("GOLDSMITH_ID");
                entity.Property(e => e.IsDeliveredMessage).HasColumnName("IS_DELIVERED_MESSAGE");
                entity.Property(e => e.ForHoeDeliveredMessage).HasColumnName("FOR_HOE_DELIVERED_MESSAGE");
                entity.Property(e => e.CorrectionDescription).HasColumnName("CORRECTION_DESCRIPTION");
                entity.Property(e => e.IsReady).HasColumnName("IS_READY").HasColumnType("bit"); // שדה החדש "isReady" מסוג בול
                entity.HasOne(d => d.Customer).WithMany(p => p.Corrections).HasForeignKey(d => d.CustomerId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("TASK");
                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");
                entity.Property(e => e.TaskDescription).HasMaxLength(100).IsUnicode(false).HasColumnName("TASK_DESCRIPTION");
                entity.Property(e => e.IsDone).HasColumnName("IS_DONE");
                entity.Property(e => e.CorrectionId).HasColumnName("CORRECTION_ID");
                entity.HasOne(d => d.Correction).WithMany(p => p.Tasks).HasForeignKey(d => d.CorrectionId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");
                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
                entity.Property(e => e.CustomerName).HasMaxLength(20).IsUnicode(false).HasColumnName("CUSTOMER_NAME");
                entity.Property(e => e.CustomerPhone).HasMaxLength(10).IsUnicode(false).HasColumnName("CUSTOMER_PHONE");
                entity.Property(e => e.CustomerDescription).HasMaxLength(50).IsUnicode(false).HasColumnName("CUSTOMER_DESCRIPTION");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("NOTES");
                entity.HasKey(e => e.NoteId); // הוספת הגדרת מפתח ראשי
                entity.Property(e => e.NoteId).HasColumnName("NOTE_ID");
                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
                entity.Property(e => e.TitleId).HasColumnName("TITELE_ID");
                entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
                entity.HasOne(d => d.Supplier).WithMany().HasForeignKey(d => d.SupplierId).OnDelete(DeleteBehavior.ClientSetNull);
            });


            modelBuilder.Entity<Title>(entity =>
            {
                entity.ToTable("TITELE");
                entity.Property(e => e.TitleId).HasColumnName("TITLE_ID");
                entity.Property(e => e.TitleName).HasMaxLength(20).IsUnicode(false).HasColumnName("TITLE_NAME");
                // הוספת קשרים נוספים למחלקות אחרות אם ישנם
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");
                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
                entity.Property(e => e.EmployeeName).HasMaxLength(20).IsUnicode(false).HasColumnName("EMPLOYEE_NAME").IsRequired();
                entity.Property(e => e.EmployeePhone).HasMaxLength(10).IsUnicode(false).HasColumnName("EMPLOYEE_PHONE");
                entity.Property(e => e.StartingWorkDate).HasColumnType("date").HasColumnName("STARTING_WORK_DATE").IsRequired(false);                                                                                                                                     
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("SUPPLIER");
                entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
                entity.Property(e => e.SupplierName).HasMaxLength(20).IsUnicode(false).HasColumnName("SUPPLIER_NAME");
                // הוספת קשרים נוספים למחלקות אחרות אם ישנם
            });

            // כאן ניתן להוסיף מיפויים נוספים לטבלאות אחרות במידת הצורך

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
