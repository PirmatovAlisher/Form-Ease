using AutoMapper;
using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Models.Identity;

namespace FormEase.Services.AutoMapper
{
	public class ApplicationUserMapper : Profile
	{
		public ApplicationUserMapper()
		{
			CreateMap<ApplicationUser, UserDisplayDto>();
		}
	}
}
