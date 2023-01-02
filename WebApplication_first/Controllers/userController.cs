using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication_first.wwwroot;

using   Entitiy;
using T_Repository;
using Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
       
        private readonly IUserService _IUserService;
        private readonly ILogger<userController> _Ilogger;

        public userController(IUserService IUserService, ILogger<userController> logger)
        {
            _Ilogger = logger;
            _IUserService = IUserService;
        }

        [HttpGet]
      
        // GET api/<userControler>/5
        [HttpGet("{id}")]
        async public Task<ActionResult<UserTable>> Get([FromQuery] string nameuser, [FromQuery] int password)
        {
            try
            {
                _Ilogger.LogInformation($"enter this {nameuser} nameuser");
                UserTable user = await _IUserService.Get(nameuser, password);
                if (user != null)
                {
                    return user;
                }
            }
            catch
                (Exception e)
            {
                _Ilogger.LogError(e.Message);
            }
            return NoContent();

        }

        // POST api/<userControler>
        [HttpPost]
        public ActionResult<UserTable> Post([FromBody] UserTable user)
        {

          
            if (_IUserService.Post(user) != null)
            {
                return user;
            }
            return StatusCode(204);

        }

        // PUT api/<userControler>/5
        [HttpPut("{userid}")]
        public void Put( int userid, [FromBody] UserTable user)
        {
            _IUserService.Put(userid, user);
        }




        // DELETE api/<userControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

      
    }
}
