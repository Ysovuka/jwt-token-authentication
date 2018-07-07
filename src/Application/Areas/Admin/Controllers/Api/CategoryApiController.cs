using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Application.Areas.Admin.Controllers.Api
{
    [Route("api/categories")]
    public class CategoryApiController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryApiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll(int? count, int? page)
        {
            if (count == null || page == null)
            {
                return _categoryService.GetAll();
            }

            return _categoryService.GetAllPAges(count, page);
        }
    }
}
