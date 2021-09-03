using Core.DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.ReportDal
{
    public class EfReportDal : EfRepositoryBase<Report, EfDbContext>, IReportDal
    {
    }
}
