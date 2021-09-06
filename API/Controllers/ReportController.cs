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
        public async Task<List<Report>> GetAllReport()
        {
            var result = _reportService.GetAll().ToList();
            return result;
        }

        [HttpGet("find")]
        public Report FindReport(Guid id)
        {
            return _reportService.Find(id);
        }

        [HttpPost("add")]
        public async Task AddReport(Report report)
        {
          
            _reportService.Add(report);
        }

        [HttpPost("update")]
        public async Task UpdateReport(Report report)
        {
            
            _reportService.Update(report);
        }

        [HttpPost("getReportForLocation")]
        public async Task GetReportLocation(string locationName)
        {

            _reportService.GetReportForLocation(locationName);
        }

    }
}
