using AutoMapper;
using e_coach_api.Models;
using e_coach_business.Services;
using e_coach_dal.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace e_coach_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;
        private readonly IMapper _mapper;
        public ExercisesController(IExerciseService exerciseService, IMapper mapper)
        {
            _exerciseService = exerciseService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ExercisePostModel> Post(ExercisePostModel exercise)
        {
            var dbExercise = _mapper.Map<Exercise>(exercise);
            await _exerciseService.PostExercise(dbExercise);

            return exercise;
        }
    }
}
