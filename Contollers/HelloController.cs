using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers

{
    public class HelloController : Controller
    {
        // localhost:5000/
        [HttpGet("")]

        public ViewResult Index()
        {
            return View();
        }

        // localhost:5000/projects
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        // localhost:5000/contact
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }



    }
}