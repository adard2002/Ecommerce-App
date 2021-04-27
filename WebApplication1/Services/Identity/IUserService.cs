using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;
using WebApplication1.Models.Identity;

namespace WebApplication1.Services.Identity
{
    public interface IUserService
    {
        Task Register(RegisterData data, ModelStateDictionary modelState);
    }
}