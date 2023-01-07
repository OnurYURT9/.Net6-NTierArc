using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerCore.DTOs;
using NLayerCore.Models;
using NLayerCore.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        public readonly IService<Product> _service;

        public ProductsController(IService<Product> service, IMapper mapper = null)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return Ok(CustomResponseDto<List<ProductDto>>, Success(200, productsDtos));
        }
           
    }
}
