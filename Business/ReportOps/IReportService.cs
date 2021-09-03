using DataAccess.EntityFramework.ReportDal;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ReportOps
{
    public interface IReportService
    {
        List<Report> GetAll();
        Report Find(Guid id);
    }
}