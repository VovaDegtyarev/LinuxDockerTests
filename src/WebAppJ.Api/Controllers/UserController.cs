using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppJ.BL.Implementation;
using WebAppJ.BL.Interfaces;

namespace WebAppJ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ILogger logger;
        //private readonly IServiceProvider serviceProvider;
        //private readonly IServiceCollection serviceCollection;

        public UserController(IUserService userService, ILogger<UserController> logger/*, IServiceProvider serviceProvider, IServiceCollection serviceCollection*/)
        {
            this.logger = logger;
            this.userService = userService;
            //this.serviceProvider = serviceProvider;
            //this.serviceCollection = serviceCollection;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var user = userService.GetUser();
            logger.LogInformation("Method GetUser called");

            return Ok(user);
        }

        [HttpGet("test")]
        public IActionResult GetTestResult()
        {
            IFactory jFactory = new JapanFactory();
            
            IEngine jEngine = jFactory.CreateEngine();
            ICar jCar = jFactory.CreateCar();
            
            var j = jCar.ReleaseCar(jEngine);

            IFactory rFactory = new RussianFactory();
            
            IEngine rEngine = rFactory.CreateEngine();
            ICar rCar = rFactory.CreateCar();

            var r = rCar.ReleaseCar(jEngine);

            //var test = serviceProvider.GetService<IUserService>();
            //var a = test?.GetUser();

            //var s = serviceCollection.AddTransient<IUserService, UserService>();
            //s.


            return Ok();
        }

    }
}
