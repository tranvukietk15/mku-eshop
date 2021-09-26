using System.Threading.Tasks;
using dotnet.Contracts;
using dotnet.Models;
using dotnet.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class CategoryController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetCategories(
            [FromQuery] PagingModel model,
            [FromServices] ICategoryService categoryService)
        {
            return Ok(await categoryService.GetCategoriesAsync(model));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(
            [FromBody] CategoryInput model,
            [FromServices] ICategoryService categoryService)
        {
            var input = new Category(model.Name)
            {
                Type = model.Type
            };

            await categoryService.CreateCategoryAsync(input);
            return Ok();
        }
    }
}