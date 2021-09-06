using Entities;
using Entities.Custom;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.ReportOps
{
    public interface IReportService
    {
        List<Report> GetAll();
        Report Find(Guid id);
        void Add(Report entity);
        void Update(Report entity);
        Task<ReportLocationCustom> GetReportForLocation(string locationName);

    }
}