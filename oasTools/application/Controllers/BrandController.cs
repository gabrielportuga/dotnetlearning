using Microsoft.AspNetCore.Mvc;
using oasTools.domain;
using oasTools.domain.repository;
using oasTools.domain.service;

namespace oasTools.Controllers
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
