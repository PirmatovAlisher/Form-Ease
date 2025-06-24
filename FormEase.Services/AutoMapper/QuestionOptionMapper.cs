using AutoMapper;
using FormEase.Core.Dtos.QuestionOptionDtos;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class QuestionOptionMapper : Profile
	{
		public QuestionOptionMapper()
		{
			CreateMap<QuestionOptionDto, QuestionOption>();
		}
	}
}
