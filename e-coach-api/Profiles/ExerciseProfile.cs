using AutoMapper;
using e_coach_api.Models;
using e_coach_dal.DbModels;

namespace e_coach_api.Profiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<ExercisePostModel, Exercise>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<Exercise, ExercisePostModel>();
        }
    }
}
