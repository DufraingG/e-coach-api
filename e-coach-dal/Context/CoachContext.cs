using Microsoft.EntityFrameworkCore;

namespace e_coach_dal.Context
{
    public class CoachContext: DbContext
    {
        public CoachContext(DbContextOptions<CoachContext> options) 
            : base(options)
        {
        }

        public DbSet<DbModels.Exercise> Exercises { get; set; }

    }
}
