using Business.ReportOps;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("getAll")]
        public async Task<List<Report>> GetAll()
        {
            var result = _reportService.GetAll().ToList();
            return result;
        }

        [HttpGet("find")]
        public Report Find(Guid id)
        {
            return _reportService.Find(id);
        }
    }
}
