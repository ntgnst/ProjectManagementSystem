using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PMS.Data.Models
{
    public partial class PMSDataContext : DbContext
    {
        public virtual DbSet<Auth> Auth { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<File> File { get; set; }
        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectEmploye> ProjectEmploye { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAuthorization> RoleAuthorization { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TaskSubTask> TaskSubTask { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-OQ51UM0;initial catalog=JobSystem;user id=sa;password=123123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auth>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Issue)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.IssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Issues");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilePath).IsRequired();

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Issue)
                    .WithMany(p => p.File)
                    .HasForeignKey(d => d.IssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_File_Issues");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.File)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_File_User");
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.FinishedDate).HasColumnType("datetime");

                entity.Property(e => e.IsSubTask).HasColumnName("isSubTask");

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ReporterId).HasColumnName("ReporterID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.PriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issues_Priority");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issues_Projects");

                entity.HasOne(d => d.Reporter)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.ReporterId)
                    .HasConstraintName("FK_Issues_User");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issues_Status");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GetUserId).HasColumnName("GetUserID");

                entity.Property(e => e.MessageContent).IsRequired();

                entity.Property(e => e.PostUserId).HasColumnName("PostUserID");

                entity.HasOne(d => d.GetUser)
                    .WithMany(p => p.MessageGetUser)
                    .HasForeignKey(d => d.GetUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User1");

                entity.HasOne(d => d.PostUser)
                    .WithMany(p => p.MessagePostUser)
                    .HasForeignKey(d => d.PostUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.IsRead)
                    .HasColumnName("isRead")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_User");
            });

            modelBuilder.Entity<ProjectEmploye>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.UserId });

                entity.ToTable("Project_Employe");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectEmploye)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Employe_Projects");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectEmploye)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Employe_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleAuthorization>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.AuthorizationId });

                entity.ToTable("Role_Authorization");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.AuthorizationId).HasColumnName("AuthorizationID");

                entity.HasOne(d => d.Authorization)
                    .WithMany(p => p.RoleAuthorization)
                    .HasForeignKey(d => d.AuthorizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Authorization_Auth");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAuthorization)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Authorization_Role");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Priority).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TaskSubTask>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.SubTaskId });

                entity.ToTable("Task_SubTask");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.SubTaskId).HasColumnName("SubTaskID");

                entity.HasOne(d => d.SubTask)
                    .WithMany(p => p.TaskSubTaskSubTask)
                    .HasForeignKey(d => d.SubTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_SubTask_Issues1");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskSubTaskTask)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_SubTask_Issues");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });
        }
    }
}
