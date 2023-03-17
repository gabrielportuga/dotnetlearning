using Microsoft.AspNetCore.Mvc;
using oasTools.domain;
using oasTools.domain.repository;
using oasTools.domain.service;

namespace oasTools.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class dealersController : ControllerBase
    {
        private readonly IDomainDealerService domainDealerService;

        public dealersController(IDomainDealerService domainDealerService)
        {
            this.domainDealerService = domainDealerService;
        }

        // GET: api/dealers
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.domainDealerService.GetAllDealers(false);

            return Ok(result);
        }

        // GET api/dealers/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"value {id}";
        }

        // POST api/dealers
        [HttpPost]
        public void Post(Dealer dealer)
        {
            try
            {
                string dealerId = this.domainDealerService.AddDealer(dealer);

                if (dealerId != "")
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
                this.domainDealerService.UpdateDealer(dealer);
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
