using DataAccess.EntityFramework.ReportStatusDal;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ReportStatusOps
{
    public class ReportStatusService : IReportStatusService
    {
        IReportStatusDal _reportStatusDal;

        public ReportStatusService(IReportStatusDal reportStatusDal)
        {
            _reportStatusDal = reportStatusDal;
        }

        public ReportStatus Find(int id)
        {
            return _reportStatusDal.Find(x => x.Id == id);
        }

        public List<ReportStatus> GetAll()
        {
            return _reportStatusDal.GetAll().ToList();
        }
    }
}
