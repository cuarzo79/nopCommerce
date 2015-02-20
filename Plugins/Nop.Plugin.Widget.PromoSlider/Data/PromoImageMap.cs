using System.Data.Entity.ModelConfiguration;
using Nop.Data.Mapping;
using Nop.Plugin.Widgets.PromoSlider.Domain;

namespace Nop.Plugin.Widgets.PromoSlider.Data
{
    public class PromoImageMap : EntityTypeConfiguration<PromoImageRecord>
    {
        public PromoImageMap()
        {
            ToTable("PromoSlider_PromoImages");

            //Map the primary key
            HasKey(m => m.PromoImageId);

            Property(m => m.PromoSliderId);
            Property(m => m.Caption);
            Property(m => m.DisplayOrder);
            Property(m => m.Url);

            this.HasRequired(i => i.PromoSlider)
                .WithMany(s => s.Images)
                .HasForeignKey(i => i.PromoSliderId);
        }
    }
}
