using Microsoft.AspNetCore.Mvc;
using users.domain;
using users.domain.repository;
using users.domain.service;

namespace users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IDomainUserService domainUserService;

        public UsersController(IDomainUserService domainUserService)
        {
            this.domainUserService = domainUserService;
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.domainUserService.GetAllUsers(false);

            return Ok(result);
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/Users
        [HttpPost]
        public void Post(User user)
        {
            try
            {
                int userId = this.domainUserService.AddUser(user);
                Created(this.Url.ToString() ?? "", new { id = userId });
            }
            catch
            {
                BadRequest();
            }

        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(User user)
        {

        }
    }
}
