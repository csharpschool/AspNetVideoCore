using Microsoft.AspNetCore.Mvc;

namespace AspNetVideoCore.Controllers
{
    //[Route("company/[controller]")]
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public ContentResult Name()
        {
            return Content("Jonas");
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
