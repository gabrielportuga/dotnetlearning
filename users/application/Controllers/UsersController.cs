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
        private readonly IRepositoryManager repositoryManager;

        public UsersController(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.repositoryManager.User.GetAllUsers(false);

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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
