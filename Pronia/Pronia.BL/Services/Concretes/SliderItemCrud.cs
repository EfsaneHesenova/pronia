using Pronia.BL.Services.Interfaces;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.BL.Services.Concretes
{
    public class SliderItemCrud : ISliderItemCrud
    {
        private readonly ProniaDbContext _context;
        public void Create(SliderItem sliderItem)
        {
            _context.SliderItems.Add(sliderItem);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            SliderItem? deleted = _context.SliderItems.Find(id);
            _context.SliderItems.Remove(deleted);
            _context.SaveChanges();
        }

        public List<SliderItem> GetAll()
        {
            List<SliderItem> sliderItems = _context.SliderItems.ToList();
            return sliderItems;
        }

        public void Update(SliderItem sliderItem)
        {
            SliderItem? searchedSliderItem = _context.SliderItems.Find(sliderItem);
            _context.SliderItems.Update(sliderItem);
            _context.SaveChanges();
        }
    }
}
