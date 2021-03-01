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
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpPost]
        [SwaggerOperation(Tags = new[] { "Product" })]
        public  IActionResult CreateProduct(CreateProductRequest request)
        {
            var response = new BaseResponse<Product>();
            try
            {
                response.data =  productService.CreateProduct(request.Name,request.CategoryId);
                response.status = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.errorMessage = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpGet]
        [SwaggerOperation(Tags = new[] { "Product" })]
        public IActionResult GetProduct(Guid productId)
        {
            var response = new BaseResponse<Product>();
            try
            {
                response.data = productService.GetProduct(productId);
                response.status = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.errorMessage = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpGet]
        [SwaggerOperation(Tags =new[] { "Product"})]
        public IActionResult GetProductList()
        {
            var response = new BaseResponse<Product>();
            try
            {
                response.dataList = productService.GetProductList();
                response.status = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.errorMessage = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpGet]
        [SwaggerOperation(Tags =new[] { "Product"})]
        public IActionResult GetCategoryProductList(Guid categoryId)
        {
            var response = new BaseResponse<Product>();
            try
            {
                response.dataList = productService.GetCategoryProductList(categoryId);
                response.status = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.status = false;
                response.errorMessage = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
