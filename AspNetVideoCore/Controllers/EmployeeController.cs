using Microsoft.AspNetCore.Mvc;

namespace AspNetVideoCore.Controllers
{
    //[Route("company/[controller]")]
    [Route("company/[controller]/[action]")]
    public class EmployeeController
    {
        public string Name()
        {
            return "Jonas";
        }

        public string Country()
        {
            return "Sweden";
        }

        public string Index()
        {
            return "Hello from Employee";
        }
    }
}
