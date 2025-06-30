using AutoMapper;
using FormEase.Core.Dtos.FormResponseDto;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class FormResponseMapper : Profile
	{
		public FormResponseMapper()
		{
			CreateMap<FormResponse, FormResponseDto>().ReverseMap();
		}
	}
}
