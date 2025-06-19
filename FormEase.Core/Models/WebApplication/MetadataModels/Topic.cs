using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEase.Core.Models.WebApplication.MetadataModels
{
    public class Topic
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // Predefined values (Education, Quiz, Other)
    }
}
