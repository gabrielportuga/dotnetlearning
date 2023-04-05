using Microsoft.AspNetCore.Mvc;
using oasTools.domain;
using oasTools.domain.repository;
using oasTools.domain.service;

namespace oasTools.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DealerController : ControllerBase
    {
        private readonly IDealerService DealerService;

        public DealerController(IDealerService DealerService)
        {
            this.DealerService = DealerService;
        }

        // GET: api/dealers
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.DealerService.GetAllDealers();

            return Ok(result);
        }

        // GET: api/dealers/vendor/1
        [HttpGet("vendor/{id}")]
        public IActionResult GetByVendor(int id)
        {
            var result = this.DealerService.GetAllDealers(id);

            return Ok(result);
        }

        // GET api/dealers/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/dealers
        [HttpPost]
        public void Post(Dealer dealer)
        {
            try
            {
                int dealerId = this.DealerService.AddDealer(dealer);

                if (dealerId != 0)
                    Created(this.Url.ToString() ?? "", new { id = dealerId });
                else
                    BadRequest();
            }
            catch
            {
                BadRequest();
            }

        }

        // PUT api/dealers/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Dealer dealer)
        {
            try
            {
                this.DealerService.UpdateDealer(dealer);
                Ok();
            }
            catch
            {

            }
        }


        // DELETE api/dealers/5
        [HttpDelete("{id}")]
        public void Delete(Dealer dealer)
        {

        }
    }
}
