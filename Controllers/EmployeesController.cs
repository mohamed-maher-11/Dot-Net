using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        static List <string> Names = new List<string>() { "Ahmed", "Mohamed", "Ali" };
        //int index = Names.Count;
        //[HttpGet]
        //public string Get()
        //{
        //    return "Welcome";
        //}
        [HttpGet]
        public IEnumerable<string> GetName()
        {
            return Names;
        }

        [HttpGet("{ID}")]
        public string GetByID(int ID)
        {
            return Names[ID];
        }

        [HttpPost]
        public string Post(string newName)
        {
            Names.Add(newName);
            return Ok().ToString();
        }

        [HttpPut]
        public string Put(int ID, string updateName)
        {
            Names[ID] = updateName;
            return NoContent().ToString();
        }

        [HttpDelete]
        public string Delete (int ID)
        {
            Names.RemoveAt(ID);
            return NoContent().ToString();
        }
    }
}
