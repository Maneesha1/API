using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPIDemo.Models
{
    public partial class PracticeContext : DbContext
    {
        public PracticeContext()
        {
        }

        public PracticeContext(DbContextOptions<PracticeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Dep> Dep { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pro> Pro { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product1> Product1 { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Work> Work { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NG1UMP4\\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer");

                entity.Property(e => e.Adrs)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contactName")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Town)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dep>(entity =>
            {
                entity.HasKey(e => e.DeptNo)
                    .HasName("PK__dep__72A83D0B75A10344");

                entity.ToTable("dep");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("Dept_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasColumnName("Dept_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__emp__129850FAD09AC8BF");

                entity.ToTable("emp");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptNo)
                    .HasColumnName("Dept_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLname)
                    .HasColumnName("emp_lname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.Emp)
                    .HasForeignKey(d => d.DeptNo)
                    .HasConstraintName("FK__emp__Dept_no__4316F928");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orders");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customerId")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.Orderdate).HasColumnType("datetime");

                entity.Property(e => e.Shipaddres)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Shipname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Shippeddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pro>(entity =>
            {
                entity.HasKey(e => e.ProjectNo)
                    .HasName("PK__pro__BC79D7FB1958E60F");

                entity.ToTable("pro");

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("project_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__product1__DD37D91AEEBB4877");

                entity.ToTable("product1");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__project__DD37D91A4EB42F68");

                entity.ToTable("project");

                entity.HasIndex(e => e.Pname)
                    .HasName("UQ__project__1FC9734CF60665CB")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("date");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.ToTable("students");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Sname).HasColumnName("sname");

                entity.Property(e => e.Std).HasColumnName("std");
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("work");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.EnterDate)
                    .HasColumnName("enter_date")
                    .HasColumnType("date");

                entity.Property(e => e.Job)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("project_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
