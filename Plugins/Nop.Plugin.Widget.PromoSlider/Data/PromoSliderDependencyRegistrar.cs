using System.Data.Entity;
using Autofac;
using Autofac.Core;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Widgets.PromoSlider.Domain;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Widgets.PromoSlider.Data
{
    public class PromoSliderDependencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_promo_slider";

        public int Order
        {
            get { return 1; }
        }

        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            this.RegisterPluginDataContext<PromoSliderObjectContext>(builder, CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<PromoSliderRecord>>()
                .As<IRepository<PromoSliderRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();

            builder.RegisterType<EfRepository<PromoImageRecord>>()
                .As<IRepository<PromoImageRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }
    }
}
