﻿namespace FormEase.Core.Dtos.ApplicationUserDtos
{
	public class UserDisplayDto
	{
		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public string FullName => $"{FirstName} {LastName}";
	}
}
