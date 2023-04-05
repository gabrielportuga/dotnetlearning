using Microsoft.AspNetCore.Mvc;
using oasTools.domain;
using oasTools.domain.repository;
using oasTools.domain.service;

namespace oasTools.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService vendorService;

        public VendorController(IVendorService vendorService)
        {
            this.vendorService = vendorService;
        }

        // GET: api/Vendors
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.vendorService.GetAllVendors();

            return Ok(result);
        }

        // GET api/Vendors/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"value {id}";
        }
    }
}
