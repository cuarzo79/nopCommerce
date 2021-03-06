﻿using Nop.Core;

namespace Nop.Plugin.Widgets.PromoSlider.Domain
{
    public class PromoImageRecord : BaseEntity
    {
        public virtual int PromoImageId { get; set; }
        public virtual int PromoSliderId { get; set; }
        public virtual string  Caption { get; set; }
        public virtual string Url { get; set; }
        public virtual string FilePath { get; set; }
        public virtual int DisplayOrder { get; set; }

        public PromoSliderRecord PromoSlider { get; set; }
    }
}