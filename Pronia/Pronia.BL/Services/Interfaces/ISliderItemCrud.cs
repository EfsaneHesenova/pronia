using Pronia.BL.Services.Concretes;
using Pronia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.BL.Services.Interfaces
{
    public interface ISliderItemCrud
    {
        public List<SliderItem> GetAll();
        public void Create(SliderItem sliderItem);
        public void Update(SliderItem sliderItem);
        public void Delete(int id);

    }
}
