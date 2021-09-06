using Autofac;
using Business.ReportOps;
using Business.ReportStatusOps;
using DataAccess.EntityFramework.ContactInfoDal;
using DataAccess.EntityFramework.ReportDal;
using DataAccess.EntityFramework.ReportStatusDal;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region DataAccessLayers
            builder.RegisterType<EfReportDal>().As<IReportDal>().SingleInstance();
            builder.RegisterType<EfReportStatusDal>().As<IReportStatusDal>().SingleInstance();
            builder.RegisterType<EfContactInfoDal>().As<IContactInfoDal>().SingleInstance();
            #endregion

            #region BusinessLayer
            builder.RegisterType<ReportService>().As<IReportService>().SingleInstance();
            builder.RegisterType<ReportStatusService>().As<IReportStatusService>().SingleInstance();
            #endregion
        }
    }
}
