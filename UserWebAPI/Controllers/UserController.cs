using Microsoft.AspNetCore.Mvc;

namespace UserWebAPI.Controllers;

[Route("api/[controller]")]
public class UserController : ControllerBase
{
    // GET api/user
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "user1", "user2" };
    }

    // GET api/user/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "get user success";
    }

    // POST api/user
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/user/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/user/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}