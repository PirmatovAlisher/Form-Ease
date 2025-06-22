using AutoMapper;
using FormEase.Core.Dtos.ApplicationUserDtos;
using FormEase.Core.Dtos.TemplateDtos;
using FormEase.Core.Interfaces.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class TemplateService : ITemplateService
	{
		private readonly ITemplateRepository _templateRepo;
		private readonly IMapper _mapper;

		public TemplateService(ITemplateRepository templateRepo, IMapper mapper)
		{
			_templateRepo = templateRepo;
			_mapper = mapper;
		}

		public async Task<List<TemplateListDto>> GetAllCreatorTemplates(string creatorId)
		{
			try
			{
				var templates = await _templateRepo.GetByCreatorIdAsync(creatorId);

				var templateListDto = _mapper.Map<List<TemplateListDto>>(templates);

				return templateListDto;
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public async Task AddAsync(TemplateCreateDto templateDto, List<UserDisplayDto> users)
		{
			try
			{
				var templateId = Guid.NewGuid();

				var template = _mapper.Map<Template>(templateDto);
				template.Id = templateId;

				var userAccess = users.
					Select(u => new UserTemplateAccess
					{
						Id = Guid.NewGuid(),
						UserId = u.Id,
						TemplateId = templateId
					}).ToList();

				template.AllowedUsers = userAccess;

				await _templateRepo.AddAsync(template);
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public async Task RemoveTemplates(List<Guid> templateIds)
		{
			await _templateRepo.DeleteRangeAsync(templateIds);
		}
	}
}
