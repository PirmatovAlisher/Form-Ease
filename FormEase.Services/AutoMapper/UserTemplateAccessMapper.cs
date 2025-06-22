using AutoMapper;
using FormEase.Core.Dtos.UserTemplateAccessDtos;
using FormEase.Core.Models.WebApplication.AccessControlModels;

namespace FormEase.Services.AutoMapper
{
	public class UserTemplateAccessMapper : Profile
	{
		public UserTemplateAccessMapper()
		{
			CreateMap<UserTemplateAccess, UserTemplateAccessDto>().ReverseMap();
		}
	}
}
