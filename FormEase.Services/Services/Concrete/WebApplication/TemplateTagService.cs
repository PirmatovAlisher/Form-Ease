using FluentValidation.Results;
using FormEase.Core.Interfaces.WebApplication.AccessControlModels;
using FormEase.Core.Interfaces.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Services.Services.Abstract.WebApplication;
using Microsoft.EntityFrameworkCore;

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

		public async Task<ValidationResult> ApplyTemplateTagChangesAsync(Guid templateId, List<string> tagNames)
		{
			var result = new ValidationResult();

			try
			{
				var existingTemplateTags = await _templateTagRepository.GetByTemplateIdAsync(templateId);
				var existingTagNames = existingTemplateTags.Select(tt => tt.Tag.Name).ToHashSet();

				existingTemplateTags ??= new List<TemplateTag>();
				existingTagNames ??= new HashSet<string>();

				var tags = await _tagRepository.GetTagsByNameAsync(tagNames);


				var toCreate = tags.Where(t => !existingTagNames.Contains(t.Name))
					.Select(t => new TemplateTag
					{
						TagId = t.Id,
						TemplateId = templateId
					});

				var toDelete = existingTemplateTags.Where(tt => !tagNames.Contains(tt.Tag.Name));


				if (toCreate != null && toCreate.Any())
				{
					await _templateTagRepository.AddRangeAsync(toCreate);
				}

				if (toDelete != null && toDelete.Any())
				{
					await _templateTagRepository.RemoveRangeAsync(toDelete);
				}
			}
			catch(DbUpdateConcurrencyException ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating the template. Please try again."
				});
			}
			catch (Exception ex)
			{
				result.Errors.Add(new ValidationFailure
				{
					PropertyName = string.Empty,
					ErrorMessage = "An error occurred while updating the template. Please try again."
				});
			}

			return result;
		}
	}
}
