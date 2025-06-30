using AutoMapper;
using FormEase.Core.Dtos.CommentDtos;
using FormEase.Core.Models.WebApplication.PermissionModels;

namespace FormEase.Services.AutoMapper
{
	public class CommentMapper : Profile
	{
		public CommentMapper()
		{
			CreateMap<Comment, CommentDto>();
		}
	}
}
