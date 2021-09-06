using DataAccess.EntityFramework.ContactInfoDal;
using DataAccess.EntityFramework.ReportDal;
using Entities;
using Entities.Custom;
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
        IContactInfoDal _contactInfoDal;

        public ReportService(IReportDal reportDal, IContactInfoDal contactInfoDal)
        {
            _reportDal = reportDal;
            _contactInfoDal = contactInfoDal;

        }

        public void Add(Report entity)
        {
            entity.ReportStatusId = 1;
            _reportDal.Add(entity);

        }

        public Report Find(Guid id)
        {
            return _reportDal.Find(x => x.Id == id);
        }

        public List<Report> GetAll()
        {
            return _reportDal.GetAll().ToList();

        }

        public void Update(Report entity)
        {
            var report = _reportDal.Find(x => x.Id == entity.Id);
            if(report != null)
            {
                report.ReportStatusId = 2;
                report.ReportDemandDate = DateTime.Now;
                _reportDal.Update(report);

            }
            else
            {
                throw new Exception("Kayıt bulunamadı.");
            }
        }

        /// <summary>
        /// Lokasyona göre istatistiki raporun gelmesi
        /// </summary>
        /// <param name="locationName"></param>
        /// <returns></returns>
        public async Task<ReportLocationCustom> GetReportForLocation(string locationName)
        {
            ReportLocationCustom reportLocationCustom = new ReportLocationCustom();

            var contactInfo = _contactInfoDal.GetAll().Where(x => x.Location.ToLower() == locationName.ToLower()).ToList();

            var locationReport = _reportDal.GetAll().ToList();


            foreach (var item in contactInfo)
            {
                foreach (var item1 in locationReport)
                {
                    if (item.Id == item1.ContactInfoId)
                    {
                        reportLocationCustom.Count = locationReport.Count;

                    }

                }
            }


            reportLocationCustom.Reports = locationReport;


            return reportLocationCustom;

        }

    }
}
