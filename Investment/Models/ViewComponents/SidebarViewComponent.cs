using Investment.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            if (CultureInfo.CurrentCulture.Name == "en-US")
            {
                ViewBag.checkEng = true;
            }
            else
                ViewBag.checkEng = false;
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItems().Where(x=>x.IsFavorit==true)));
        }
    }
}
