using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public interface IFileService
    {
        Task<string> Upload(IFormFile profileImage);
    }

    public class AdaraFileService : IFileService
    {
        public async Task<string> Upload(IFormFile profileImage)
        {
            return "https://avatars.githubusercontent.com/u/69268585?v=4";
        }
    }
}