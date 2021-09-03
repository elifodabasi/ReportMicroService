using Autofac;
using Business.ReportOps;
using DataAccess.EntityFramework.ReportDal;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region DataAccessLayers
            builder.RegisterType<EfReportDal>().As<IReportDal>().SingleInstance();
            #endregion

            #region BusinessLayer
            builder.RegisterType<ReportService>().As<IReportService>().SingleInstance();
            #endregion
        }
    }
}
