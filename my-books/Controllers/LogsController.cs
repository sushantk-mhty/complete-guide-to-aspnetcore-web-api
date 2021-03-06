using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using System;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private LogsService _logsService;
        public LogsController(LogsService logsService)
        {
            this._logsService=logsService;
        }
        [HttpGet("get-all-logs-from-db")]
        public IActionResult GetAllLogsFromDb()
        {
            try
            {
                var logs = _logsService.GetAllLogsFromDB();
                return Ok(logs); 
            }
            catch (Exception)
            {
                return BadRequest("Could not load logs from Database");
            }
        }
    }
}
