using Microsoft.AspNetCore.Components.Forms;

namespace FormEase.Services.Services.Abstract.WebApplication
{
	public interface IImageUploadService
	{
		Task<string> UploadImageAsync(IBrowserFile file);
	}
}
