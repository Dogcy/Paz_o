using CRUD_Repository.DTO;
using CRUD_Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Paz_o.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PazController : ControllerBase
    {
        private readonly ICategorysService _categorysService;
        public PazController(ICategorysService categorysService)
        {
            this._categorysService = categorysService;
        }
        [HttpGet]
        public IActionResult GetCategories()
        {

            return Ok(_categorysService.GetAllCategory());
        }
        [HttpPost]
        public IActionResult AddCategory(CategoriesDTO category)
        {
            _categorysService.AddNewCategory(category);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCategory(CategoriesDTO category)
        {
            _categorysService.EditCategory(category);
            return Ok();
        }
        [HttpDelete, Route("{number}")]
        public IActionResult DeleteCategory(int Id)
        {
            _categorysService.DeleteCategory(Id);
            return Ok();
        }
    }
}
