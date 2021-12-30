using e_coach_dal.Context;
using e_coach_dal.DbModels;

namespace e_coach_business.Services
{
    public interface IExerciseService
    {
        Task PostExercise(Exercise exercise);
    }

    public class ExerciseService : IExerciseService
    {
        private readonly CoachContext _context;

        public ExerciseService(CoachContext context)
        {
            _context = context;
        }

        public async Task PostExercise(Exercise exercise)
        {
            await _context.Exercises.AddAsync(exercise);
            await _context.SaveChangesAsync();
        }
    }
}
