using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
  public class ReportSeed : IEntityTypeConfiguration<Report>
    {
        private readonly Guid[] _Ids;

        public ReportSeed(Guid[] Ids)
        {
            _Ids = Ids;

        }

        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasData(
          new Report
          {
              Id = _Ids[0],
              ReportDemandDate = DateTime.Now,
              ReportStatusId = 1

          }
         ) ;
        }
    }
}
