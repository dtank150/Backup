using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace StudentAPIDemo.Repositories
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file, string fileName);
    }
}
