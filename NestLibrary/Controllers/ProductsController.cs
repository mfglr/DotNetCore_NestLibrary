﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NestLibrary.Dtos;
using NestLibrary.Services;

namespace NestLibrary.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct(ProductCreateDto request)
        {
            return Ok(await _productService.SaveAsync(request));
        }
    }
}