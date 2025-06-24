using FormEase.Core.Interfaces.WebApplication.AccessControlModels;
using FormEase.Core.Interfaces.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Services.Services.Abstract.WebApplication;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class TemplateTagService : ITemplateTagService
	{
		private readonly ITemplateTagRepository _templateTagRepository;
		private readonly ITagRepository _tagRepository;

		public TemplateTagService(ITagRepository tagRepository, ITemplateTagRepository templateTagRepository = null)
		{
			_tagRepository = tagRepository;
			_templateTagRepository = templateTagRepository;
		}

		public async Task<List<TemplateTag>> CreateTemplateTagsAsync(Guid templateId, List<string> tagNames)
		{
			var templateTags = new List<TemplateTag>();

			foreach (var tag in tagNames)
			{
				var tagId = await _tagRepository.GetTagIdByNameAsync(tag);
				var templateTag = new TemplateTag
				{
					Id = Guid.NewGuid(),
					TagId = tagId,
					TemplateId = templateId
				};
				templateTags.Add(templateTag);
			}

			await _templateTagRepository.AddRangeAsync(templateTags);

			return templateTags;
		}
	}
}
