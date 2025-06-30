using AutoMapper;
using FormEase.Core.Dtos.QuestionOptionDtos;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class SelectedOptionMapper : Profile
	{
		public SelectedOptionMapper()
		{
			CreateMap<SelectedOption, SelectedOptionDto>().ReverseMap();
		}
	}
}
