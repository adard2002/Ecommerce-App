using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public interface IFileService
    {
        Task<string> Upload(IFormFile profileImage);
    }
}