using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;
namespace TaskManager.Infrastructure.Seed
{
    public static class SeedWorkType
    {
        public static void WorkType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeWork>().HasData(TypeSeed());
        }

        private static TypeWork[] TypeSeed()
        {
            return new TypeWork[]
            {
                new TypeWork
                {
                     Id = 1,
                     Type = "Bug"
                },

                new TypeWork
                {
                     Id = 2,
                     Type = "Task"
                },

                new TypeWork
                {
                     Id = 3,
                     Type = "Improvement"
                },

                new TypeWork
                {
                     Id = 4,
                     Type = "Research"
                },
            };
        }
    }
}
