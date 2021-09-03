using DataAccess.EntityFramework.ReportDal;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ReportOps
{
    public class ReportService : IReportService
    {
        IReportDal _reportDal;

        public ReportService(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public Report Find(Guid id)
        {
          return  _reportDal.Find(x => x.Id == id);
        }

        public List<Report> GetAll()
        {
            return _reportDal.GetAll().ToList();
                
        }
    }
}
