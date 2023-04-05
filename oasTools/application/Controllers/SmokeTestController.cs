using Microsoft.AspNetCore.Mvc;
using oasTools.domain;
using oasTools.domain.repository;
using oasTools.domain.service;
using onboarding;

namespace oasTools.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmokeTestController : ControllerBase
    {
        private readonly SmokeTest smokeTest = new SmokeTest();

        public SmokeTestController()
        {
        }

        // GET: api/smoketest
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var token = await this.smokeTest.GetAuthToken();
            await this.smokeTest.CheckPassword("046958fd-bb0b-4279-bf46-b50cb5b2f7bb", token);
            var vehicleDetails = await this.smokeTest.ChassisPrePopulation(token);
            //var result = this.smokeTest.GetServices(token, vehicleDetails);

            return Ok(vehicleDetails);
        }
    }
}
