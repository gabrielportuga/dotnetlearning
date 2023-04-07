using Microsoft.AspNetCore.Mvc;
using OasTools.domain;
using OasTools.domain.repository;
using OasTools.domain.service;

namespace OasTools.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService brandService;

        public BrandController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        // GET: api/Brands
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.brandService.GetAllBrands();

            return Ok(result);
        }

        // GET api/Brands/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"value {id}";
        }
    }
}
