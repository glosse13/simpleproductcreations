using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleProductCreation.Domain.Catalog.Entities;
using SimpleProductCreation.Domain.Catalog.Interfaces;
using SimpleProductCreation.Models;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductCreation.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        [SwaggerOperation(Tags =new[] { "Category"})]
        public  IActionResult GetCategories()
        {
            var response = new BaseResponse<Category>();
            try
            {
                response.dataList = categoryService.GetCategories();
                response.status = true;
                return Ok(response);
            }
            catch (Exception ex )
            {
                response.status = false;
                response.errorMessage = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
