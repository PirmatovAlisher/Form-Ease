using AutoMapper;
using FormEase.Core.Dtos.AnswerDros;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class AnswerMapper : Profile
	{
		public AnswerMapper()
		{
			CreateMap<Answer, AnswerDto>().ReverseMap();
		}
	}
}
