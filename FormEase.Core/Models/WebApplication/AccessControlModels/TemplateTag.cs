using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.MetadataModels;

namespace FormEase.Core.Models.WebApplication.AccessControlModels
{
    public class TemplateTag
    {
        public Guid Id { get; set; }

        public Guid TemplateId { get; set; }
        public Template Template { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
