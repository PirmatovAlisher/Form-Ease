using AutoMapper;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class TemplateMapper : Profile
	{
		public TemplateMapper()
		{
			CreateMap<TemplateCreateDto, Template>();
			CreateMap<Template, TemplateListDto>();
		}
	}
}
