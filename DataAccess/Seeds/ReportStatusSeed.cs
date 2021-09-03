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
   public class ReportStatusSeed : IEntityTypeConfiguration<ReportStatus>
    {
       

        public void Configure(EntityTypeBuilder<ReportStatus> builder)
        {
            builder.HasData(
          new ReportStatus
          {
              Id = 1,
              Status = "Hazırlanıyor"

          }
         ) ;

            builder.HasData(
         new ReportStatus
         {
             Id = 2,
             Status = "Tamamlandı"

         }
        );
        }
    }
}
