using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManager.Infrastructure.Seed;
using TaskManager.Core.Entities;

namespace TaskManager.Infrastructure.Data
{
    public class WorkContext : IdentityDbContext<User>
    {
        public WorkContext() { }

        public WorkContext(DbContextOptions<WorkContext> options)
        : base(options) { }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<UserWork> UserWorks { get; set; }
        public virtual DbSet<StatusWork> WorkStatus { get; set; }
        public virtual DbSet<TypeWork> WorkTypes { get; set; }
        public virtual DbSet<TypeComment> CommentTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserWork>()
                .HasKey(userWork => new { userWork.UserId, userWork.WorkId });
            modelBuilder.Entity<UserWork>()
                .HasOne(userWork => userWork.Work)
                .WithMany(user => user.UserWorks)
                .HasForeignKey(userWork => userWork.WorkId);
            modelBuilder.Entity<UserWork>()
             .HasOne(userWork => userWork.User)
             .WithMany(work => work.UserWorks)
             .HasForeignKey(userWork => userWork.UserId);


            modelBuilder.Roles();
            modelBuilder.WorkStatus();
            modelBuilder.CommentType();
            modelBuilder.WorkType();

            base.OnModelCreating(modelBuilder);
        }
    }
}
