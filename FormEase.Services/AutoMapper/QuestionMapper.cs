using AutoMapper;
using FormEase.Core.Dtos.QuestionDtos;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class QuestionMapper : Profile
	{
		public QuestionMapper()
		{
			CreateMap<QuestionDto, Question>().ReverseMap();
		}
	}
}
