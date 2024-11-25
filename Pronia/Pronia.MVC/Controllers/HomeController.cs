using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Interfaces;
using Pronia.DAL.Models;
using System;

namespace Pronia.MVC.Controllers
{
    public class HomeController : Controller
    {
        ISliderItemCrud _service;

        public HomeController(ISliderItemCrud service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
          List<SliderItem> sliderItems = _service.GetAll();
            return View(sliderItems);
        }

    }
}
