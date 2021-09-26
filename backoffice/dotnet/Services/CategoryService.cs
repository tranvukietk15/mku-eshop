using System.Linq;
using System.Threading.Tasks;
using dotnet.Contracts;
using dotnet.Models;
using dotnet.Models.Db;
using dotnet.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<PaginationContract<Category>> GetCategoriesAsync(PagingModel model)
        {
            var query = _context.Set<Category>().AsQueryable();
            var total = await query.CountAsync();
            var skip = model.Size * model.Index;
            var items = await query.Skip(skip).Take(model.Size).ToListAsync();
            return new PaginationContract<Category>()
            {
                Items = items,
                Total = total
            };
        }
        
        public async Task CreateCategoryAsync(Category model)
        {
            _context.Set<Category>().Add(model);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}