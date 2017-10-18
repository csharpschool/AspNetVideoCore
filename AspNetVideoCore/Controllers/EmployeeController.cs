using Microsoft.AspNetCore.Mvc;

namespace AspNetVideoCore.Controllers
{
    [Route("[controller]")]
    public class EmployeeController
    {
        [Route("[action]")]
        public string Name()
        {
            return "Jonas";
        }

        [Route("[action]")]
        public string Country()
        {
            return "Sweden";
        }

        [Route("")]
        [Route("[action]")]
        public string Index()
        {
            return "Hello from Employee";
        }
    }
}
