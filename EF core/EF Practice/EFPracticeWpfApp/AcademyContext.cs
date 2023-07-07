using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFPracticeWpfApp;

public partial class AcademyContext : DbContext
{
    public AcademyContext()
    {
    }

    public AcademyContext(DbContextOptions<AcademyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Curator> Curators { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupsCurrator> GroupsCurrators { get; set; }

    public virtual DbSet<GroupsLecture> GroupsLectures { get; set; }

    public virtual DbSet<Lecture> Lectures { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }
    
    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Data Source=DESKTOP-0CHK3G3;Initial Catalog=ACADEMY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        ConfigurationBuilder builder = new();
        builder.AddJsonFile("appsettings.json");

        IConfigurationRoot config = builder.Build();
        
        var connectionString = config.GetConnectionString("ACADEMY");

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curators__3213E83F657155AC");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3213E83F84741F97");

            entity.HasIndex(e => e.Name, "UQ__Departme__737584F68FD7CF82").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Financing).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Faculty).WithMany(p => p.Departments)
                .HasForeignKey(d => d.FacultyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Departmen__Facul__5629CD9C");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facultie__3213E83FD2FEF8B4");

            entity.HasIndex(e => e.Name, "UQ__Facultie__737584F654A683F0").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Financing).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Groups__3213E83F533D220A");

            entity.HasIndex(e => e.Name, "UQ__Groups__737584F6D865EE52").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(10);

            entity.HasOne(d => d.Department).WithMany(p => p.Groups)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Groups__Departme__5BE2A6F2");
        });

        modelBuilder.Entity<GroupsCurrator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GroupsCu__3213E83F8C734C44");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Curator).WithMany(p => p.GroupsCurrators)
                .HasForeignKey(d => d.CuratorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupsCur__Curat__5EBF139D");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsCurrators)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupsCur__Group__5FB337D6");
        });

        modelBuilder.Entity<GroupsLecture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GroupsLe__3213E83F81991332");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsLectures)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupsLec__Group__628FA481");

            entity.HasOne(d => d.Lecture).WithMany(p => p.GroupsLectures)
                .HasForeignKey(d => d.LectureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupsLec__Lectu__6383C8BA");
        });

        modelBuilder.Entity<Lecture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lectures__3213E83F6996A7E1");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Subject).WithMany(p => p.Lectures)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Lectures__Subjec__45F365D3");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Lectures)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Lectures__Teache__46E78A0C");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subjects__3213E83FADF9FD6A");

            entity.HasIndex(e => e.Name, "UQ__Subjects__737584F61A008B94").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3213E83F1E8B5F76");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Salary)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
