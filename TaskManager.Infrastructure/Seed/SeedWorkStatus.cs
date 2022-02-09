using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;

namespace TaskManager.Infrastructure.Seed
{
    public static class SeedWorkStatus
    {
        public static void WorkStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusWork>().HasData(StatusSeed());
        }

        private static StatusWork[] StatusSeed()
        {
            return new StatusWork[]
            {
                new StatusWork
                {
                     Id = 1,
                     Status = "Open"
                },

                new StatusWork
                {
                     Id = 2,
                     Status = "InProgress"
                },

                new StatusWork
                {
                     Id = 3,
                     Status = "Closed"
                },
            };
        }
    }
}
