using Pronia.DAL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.DAL.Models
{
    public class SliderItem: BaseEntity
    {
        public string Title { get; set; }
        public int Offer { get; set; }
        public string Description { get; set; }
        public string MainImageUrl { get; set; }
    }
}
