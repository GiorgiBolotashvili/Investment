using Investment.Domain;
using Investment.Models.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Controllers
{
    [Route("service")]
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IStringLocalizer _localizer;

        public ServicesController(IStringLocalizerFactory factory, DataManager dataManager)
        {
            _localizer = factory.Create(typeof(SharedResource));
            this.dataManager = dataManager;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index(Guid id, byte status)
        {
            if (CultureInfo.CurrentCulture.Name =="en-US")
            {
                ViewBag.checkEng = true;
            }
            else
                ViewBag.checkEng = false;


            ViewBag.IsMainPage = false;
            if (status>0)
            {
                return View("Index", dataManager.ServiceItems.GetServiceItems().Where(x=>x.Status==status));
            }
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }

    }
}
