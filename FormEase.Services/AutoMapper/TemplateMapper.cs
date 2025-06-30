using AutoMapper;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Services.AutoMapper
{
	public class TemplateMapper : Profile
	{
		public TemplateMapper()
		{
			CreateMap<TemplateCreateDto, Template>();

			CreateMap<TemplateEditDto, Template>().ReverseMap();

			CreateMap<Template, TemplateListDto>();

			CreateMap<Template, TemplateDisplayDto>();

			CreateMap<Template, TemplateFillDto>()
				   .ForMember(d => d.TopicName, o => o.MapFrom(src => src.Topic.Name));

			CreateMap<TemplateTag, TemplateTagViewDto>();
		}
	}
}
