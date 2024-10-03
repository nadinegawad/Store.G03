﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.G03.Core.Services.contract;

namespace Store.G03.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> GetAllProducts()
        {
            var result=await _productService.GetAllProductsAsync();
            return Ok(result);
        }
        [HttpGet("brands")]
        public async Task<IActionResult> GetAllBrands()
        {
            var result = await _productService.GetAllBrandsAsync();
            return Ok(result);
        }
        [HttpGet("types")]
        public async Task<IActionResult> GetAllTypes()
        {
            var result = await _productService.GetAllTypesAsync();
            return Ok(result);
        }
        public  async Task<IActionResult> GetproductById(int? id)
        {
            var result = await _productService.GetProductById(id.Value);
            if(result is null)
            {
                return NotFound($"The Product With Id :{id} Not Found in DB");
            }
            return Ok(result);
        }
    }
}
