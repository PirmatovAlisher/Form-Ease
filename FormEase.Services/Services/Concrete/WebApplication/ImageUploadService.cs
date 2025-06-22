using FormEase.Services.Services.Abstract.WebApplication;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace FormEase.Services.Services.Concrete.WebApplication
{
	public class ImageUploadService : IImageUploadService
	{
		private readonly HttpClient _httpClient;
		private readonly IConfiguration _configuration;
		private readonly string _imgBBApiKey;
		private readonly string _uploadUrl;
		private const long MaxFileSize = 5 * 1024 * 1024; // 5 MB

		public ImageUploadService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;
			_configuration = configuration;
			_imgBBApiKey = configuration["ImgBB:ApiKey"];
			_uploadUrl = configuration["ImgBB:UploadUrl"];
		}

		public async Task<string> UploadImageAsync(IBrowserFile file)
		{
			if (file == null)
			{
				throw new ArgumentNullException(nameof(file), "No file provided for upload.");
			}

			if (file.Size > MaxFileSize)
			{
				throw new Exception($"File size exceeds {MaxFileSize / (1024 * 1024)}MB limit.");
			}

			try
			{
				using var content = new MultipartFormDataContent();
				var fileContent = new StreamContent(file.OpenReadStream(MaxFileSize));
				fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(file.ContentType);
				content.Add(fileContent, "image", file.Name);

				var requestUri = $"{_uploadUrl}?key={_imgBBApiKey}";

				var response = await _httpClient.PostAsync(requestUri, content);

				if (response.IsSuccessStatusCode)
				{
					var result = await response.Content.ReadFromJsonAsync<ImgBBResponse>();
					if (result != null && result.success && result.data != null)
					{
						return result.data.url;
					}
					else
					{
						var errorDetails = await response.Content.ReadAsStringAsync();
						throw new Exception($"ImgBB upload failed: {result?.status_txt ?? "Unknown error"}. Details: {errorDetails}");
					}
				}
				else
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					throw new Exception($"Image upload failed: {response.ReasonPhrase} - {errorContent}");
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error in ImgBBImageUploadService: {ex.Message}");
				throw; // Re-throw the exception for the caller to handle
			}
		}

		// Helper classes for parsing ImgBB API response
		private class ImgBBResponse
		{
			public bool success { get; set; }
			public int status { get; set; }
			public string status_txt { get; set; }
			public ImgBBData data { get; set; }
		}

		private class ImgBBData
		{
			public string id { get; set; }
			public string title { get; set; }
			public string url_viewer { get; set; }
			public string url { get; set; }
			public string display_url { get; set; }
			public int width { get; set; }
			public int height { get; set; }
			public int size { get; set; }
			public long time { get; set; }
			public long expiration { get; set; }
			public ImgBBImage image { get; set; }
			public ImgBBThumb thumb { get; set; }
			public ImgBBMdeium medium { get; set; }
			public string delete_url { get; set; }
		}

		private class ImgBBImage
		{
			public string filename { get; set; }
			public string name { get; set; }
			public string mime { get; set; }
			public string extension { get; set; }
			public string url { get; set; }
		}

		private class ImgBBThumb
		{
			public string filename { get; set; }
			public string name { get; set; }
			public string mime { get; set; }
			public string extension { get; set; }
			public string url { get; set; }
		}

		private class ImgBBMdeium
		{
			public string filename { get; set; }
			public string name { get; set; }
			public string mime { get; set; }
			public string extension { get; set; }
			public string url { get; set; }
		}
	}
}




