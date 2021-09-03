using Business.ReportStatusOps;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ReportStatusController : ControllerBase
    {
        IReportStatusService _reportStatusService;

        public ReportStatusController(IReportStatusService reportStatusService)
        {
            _reportStatusService = reportStatusService;
        }

        [HttpGet("getAll")]
        public async Task<List<ReportStatus>> GetAll()
        {
            var result = _reportStatusService.GetAll().ToList();
            return result;
        }

        [HttpGet("find")]
        public ReportStatus Find(int id)
        {
            return _reportStatusService.Find(id);
        }
    }
}
