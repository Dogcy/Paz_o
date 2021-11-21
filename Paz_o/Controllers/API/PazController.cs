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

            return Ok();
        }
        [HttpPost]
        public IActionResult AddCategory()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCategory()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCategory()
        {
            return Ok();
        }
    }
}
