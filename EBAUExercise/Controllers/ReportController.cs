using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace EBAUExercise.Controllers
{
    //[ApiController]
    [Route("[controller]/[action]")]
    public class ReportController : ControllerBase
    {
        private readonly ReportService _reportService;

        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public IActionResult CustomerReport()
        {
            return new JsonResult(_reportService.CustomerReport());
        }

        [HttpGet]
        public IActionResult StoreDailyReport()
        {
            return new JsonResult(_reportService.StoreDailyReport());
        }
    }
}