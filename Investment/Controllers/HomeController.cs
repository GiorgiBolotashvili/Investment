using Investment.Domain;
using Investment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        //private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        //private readonly IStringLocalizerFactory localizerFactory;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
            //this._sharedLocalizer = sharedResource;
            //this.localizerFactory = localizerFactory;
        }


        public IActionResult Index()
        {
          //  ViewBag.IsMainPage = true;

            //ViewBag.Text = _sharedLocalizer["CompanyText"];
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }

/*        private IStringLocalizer<SharedResource> GetSharedLocalizer()
        {
            var culture = CultureInfo.CurrentCulture.Name;
            return localizerFactory.Create<SharedResource>(culture);
        }*/
    }
}
