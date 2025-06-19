using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.MetadataModels;
using Microsoft.EntityFrameworkCore;

namespace FormEase.Infrastructure.PostgreSQL.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedTopics(builder);
            SeedTemplates(builder);
            SeedQuestions(builder);
            SeedQuestionOptions(builder);
            SeedTags(builder);
            SeedTemplateTags(builder);
            SeedUserTemplateAccess(builder);
            SeedFormResponses(builder);
            SeedAnswers(builder);
        }

        private static void SeedTopics(ModelBuilder builder)
        {
            builder.Entity<Topic>().HasData(
                new Topic { Id = Guid.Parse("00000000-0000-0000-0001-000000000001"), Name = "Education" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0001-000000000002"), Name = "Quiz" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0001-000000000003"), Name = "Survey" },
                new Topic { Id = Guid.Parse("00000000-0000-0000-0001-000000000004"), Name = "Other" }
            );
        }

        private static void SeedTemplates(ModelBuilder builder)
        {
            builder.Entity<Template>().HasData(
                new Template
                {
                    Id = Guid.Parse("00000000-0000-0000-0002-000000000001"),
                    Title = "Math Assessment",
                    Description = "Basic math skills evaluation",
                    ImageUrl = "https://storage.example.com/math-assessment.jpg",
                    IsPublic = true,
                    CreatedAt = new DateTime(2023, 1, 15),
                    UpdatedAt = new DateTime(2023, 1, 15),
                    CreatorId = Guid.Parse("00000000-0000-0000-0000-000000000002").ToString(),
                    TopicId = Guid.Parse("00000000-0000-0000-0001-000000000001")
                },
                new Template
                {
                    Id = Guid.Parse("00000000-0000-0000-0002-000000000002"),
                    Title = "Employee Feedback",
                    Description = "Quarterly employee satisfaction survey",
                    ImageUrl = null,
                    IsPublic = false,
                    CreatedAt = new DateTime(2023, 2, 20),
                    UpdatedAt = new DateTime(2023, 2, 20),
                    CreatorId = Guid.Parse("00000000-0000-0000-0000-000000000001").ToString(), // Admin
                    TopicId = Guid.Parse("00000000-0000-0000-0001-000000000003")
                }
            );
        }

        private static void SeedQuestions(ModelBuilder builder)
        {
            builder.Entity<Question>().HasData(
                // Math Assessment Questions
                new Question
                {
                    Id = Guid.Parse("00000000-0000-0000-0003-000000000001"),
                    Title = "What is 15 × 8?",
                    Description = "Calculate the product",
                    Order = 1,
                    IsRequired = true,
                    Type = QuestionType.Number,
                    ShowInResponseList = true,
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000001")
                },
                new Question
                {
                    Id = Guid.Parse("00000000-0000-0000-0003-000000000002"),
                    Title = "Describe your approach to problem solving",
                    Description = "In your own words",
                    Order = 2,
                    IsRequired = false,
                    Type = QuestionType.Paragraph,
                    ShowInResponseList = false,
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000001")
                },
                // Employee Feedback Questions
                new Question
                {
                    Id = Guid.Parse("00000000-0000-0000-0003-000000000003"),
                    Title = "Select benefits you use",
                    Description = "Check all that apply",
                    Order = 1,
                    IsRequired = true,
                    Type = QuestionType.Checkboxes,
                    ShowInResponseList = true,
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000002")
                }
            );
        }

        private static void SeedQuestionOptions(ModelBuilder builder)
        {
            builder.Entity<QuestionOption>().HasData(
                new QuestionOption
                {
                    Id = Guid.Parse("00000000-0000-0000-0004-000000000001"),
                    Value = "Health Insurance",
                    QuestionId = Guid.Parse("00000000-0000-0000-0003-000000000003")
                },
                new QuestionOption
                {
                    Id = Guid.Parse("00000000-0000-0000-0004-000000000002"),
                    Value = "Retirement Plan",
                    QuestionId = Guid.Parse("00000000-0000-0000-0003-000000000003")
                },
                new QuestionOption
                {
                    Id = Guid.Parse("00000000-0000-0000-0004-000000000003"),
                    Value = "Paid Time Off",
                    QuestionId = Guid.Parse("00000000-0000-0000-0003-000000000003")
                }
            );
        }

        private static void SeedTags(ModelBuilder builder)
        {
            builder.Entity<Tag>().HasData(
                new Tag { Id = Guid.Parse("00000000-0000-0000-0005-000000000001"), Name = "Mathematics" },
                new Tag { Id = Guid.Parse("00000000-0000-0000-0005-000000000002"), Name = "Algebra" },
                new Tag { Id = Guid.Parse("00000000-0000-0000-0005-000000000003"), Name = "HR" },
                new Tag { Id = Guid.Parse("00000000-0000-0000-0005-000000000004"), Name = "Workplace" }
            );
        }

        private static void SeedTemplateTags(ModelBuilder builder)
        {
            builder.Entity<TemplateTag>().HasData(
                new TemplateTag
                {
                    Id = Guid.Parse("00000000-0000-0000-0006-000000000001"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000001"),
                    TagId = Guid.Parse("00000000-0000-0000-0005-000000000001")
                },
                new TemplateTag
                {
                    Id = Guid.Parse("00000000-0000-0000-0006-000000000002"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000001"),
                    TagId = Guid.Parse("00000000-0000-0000-0005-000000000002")
                },
                new TemplateTag
                {
                    Id = Guid.Parse("00000000-0000-0000-0006-000000000003"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000002"),
                    TagId = Guid.Parse("00000000-0000-0000-0005-000000000003")
                }
            );
        }

        private static void SeedUserTemplateAccess(ModelBuilder builder)
        {
            builder.Entity<UserTemplateAccess>().HasData(
                new UserTemplateAccess
                {
                    Id = Guid.Parse("00000000-0000-0000-0007-000000000001"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000002"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002").ToString()  // Creator1
                },
                new UserTemplateAccess
                {
                    Id = Guid.Parse("00000000-0000-0000-0007-000000000002"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000002"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003").ToString()  // Respondent1
				}
            );
        }

        private static void SeedFormResponses(ModelBuilder builder)
        {
            builder.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    Id = Guid.Parse("00000000-0000-0000-0008-000000000001"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000001"),
                    RespondentId = Guid.Parse("00000000-0000-0000-0000-000000000003").ToString(), // Respondent1
                    CreatedAt = new DateTime(2023, 3, 10),
                    UpdatedAt = new DateTime(2023, 3, 10)
                },
                new FormResponse
                {
                    Id = Guid.Parse("00000000-0000-0000-0008-000000000002"),
                    TemplateId = Guid.Parse("00000000-0000-0000-0002-000000000002"),
                    RespondentId = Guid.Parse("00000000-0000-0000-0000-000000000003").ToString(), // Respondent1
                    CreatedAt = new DateTime(2023, 3, 12),
                    UpdatedAt = new DateTime(2023, 3, 12)
                }
            );
        }

        private static void SeedAnswers(ModelBuilder builder)
        {
            builder.Entity<Answer>().HasData(
                // Math Assessment Answers
                new Answer
                {
                    Id = Guid.Parse("00000000-0000-0000-0009-000000000001"),
                    Value = "120", // 15 × 8
                    QuestionId = Guid.Parse("00000000-0000-0000-0003-000000000001"),
                    ResponseId = Guid.Parse("00000000-0000-0000-0008-000000000001")
                },
                new Answer
                {
                    Id = Guid.Parse("00000000-0000-0000-0009-000000000002"),
                    Value = "I break problems into smaller steps",
                    QuestionId = Guid.Parse("00000000-0000-0000-0003-000000000002"),
                    ResponseId = Guid.Parse("00000000-0000-0000-0008-000000000001")
                },
                // Employee Feedback Answers
                new Answer
                {
                    Id = Guid.Parse("00000000-0000-0000-0009-000000000003"),
                    Value = "[\"Health Insurance\", \"Paid Time Off\"]", // JSON array
                    QuestionId = Guid.Parse("00000000-0000-0000-0003-000000000003"),
                    ResponseId = Guid.Parse("00000000-0000-0000-0008-000000000002")
                }
            );
        }
    }
}
