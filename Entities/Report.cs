using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Report : IEntity
    {
        public Report()
        {
           // ReportStatuses = new Collection<ReportStatus>();
        }

        public Guid Id { get; set; }
        public DateTime ReportDemandDate { get; set; }
        public int ReportStatusId { get; set; }

        public Guid ContactInfoId { get; set; }
        public virtual ReportStatus ReportStatus { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
        //public ICollection<ReportStatus> ReportStatuses { get; set; }
    }
}
