using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly DoWorkService _doWorkService;

        public TasksController(DoWorkService doWorkService)
        {
            _doWorkService = doWorkService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // eg. CountingService.Increment()
            CountingService.Reset();
            CountingService.Increment();
            return Ok(new
            {
                IsDataSaved = _doWorkService.DoWork(),
                Count = CountingService.Get() // return the current value of the counter here.
            }); ;
        }
    }
}
