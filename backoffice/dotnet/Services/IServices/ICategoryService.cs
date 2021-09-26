using System.Threading.Tasks;
using dotnet.Contracts;
using dotnet.Models;

namespace dotnet.Services.IServices
{
    public interface ICategoryService
    {
        Task<PaginationContract<Category>> GetCategoriesAsync(PagingModel model);
        Task CreateCategoryAsync(Category model);
    }
}