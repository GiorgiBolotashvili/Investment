using Investment.Domain;
using Investment.Domain.Entities;
using Investment.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        string[] status = { "შესრულებული", "მიმდინარე", "დაგეგმილი" };
        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ServiceItem() : dataManager.ServiceItems.GetServiceItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(ServiceItem model, IFormFile titleMainImagePath, IFormFile titleSecondImagePath)
        {
            bool mainImage = true;
            bool secondImage = true;
            if (ModelState.IsValid)
            {
                if (titleMainImagePath != null)
                {
                    if (IsValidFile(titleMainImagePath, true))
                    {
                        model.TitleMainImagePath = titleMainImagePath.FileName;
                        using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleMainImagePath.FileName), FileMode.Create))
                        {
                            titleMainImagePath.CopyTo(stream);
                        }
                        mainImage = false;
                    }
                    if (IsValidFile(titleSecondImagePath, false))
                    {
                        model.TitleSecondImagePath = titleSecondImagePath.FileName;
                        using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleSecondImagePath.FileName), FileMode.Create))
                        {
                            titleSecondImagePath.CopyTo(stream);
                        }
                        secondImage = false;
                    }
                    if (mainImage || secondImage)
                    {
                        return View(model);
                    }
                }
                dataManager.ServiceItems.SaveServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        private bool IsValidFile(IFormFile file, bool main)
        {
            string fileExtension = Path.GetExtension(file.FileName);
            var  maxFileSize = 2 * 1024 * 1024;
            string[] fileExtensions = { ".bmp", ".jpg", ".png", ".gif", ".jpeg" };

            if (!fileExtensions.Contains(fileExtension.ToLower()))
            {
                // ModelState.AddModelError("titleImageFile", "Invalid file type. only JPG, JPEG, PNG, GIF and BMP files are allowed ");
                if (main)
                {
                    ViewBag.MainImageFormatError = "Invalid file type. only JPG, JPEG, PNG, GIF and BMP files are allowed "; 
                }
                else
                {
                    ViewBag.SecondImageFormatError = "Invalid file type. only JPG, JPEG, PNG, GIF and BMP files are allowed ";
                }
                return false;
            }
            if (file.Length > maxFileSize)
            {
              //  ModelState.AddModelError("titleImageFile", "File size cannot exceed 2 MB");
                if (main)
                {
                    ViewBag.MainImageFormatError = "File size cannot exceed 2 MB";
                }
                else
                {
                    ViewBag.SecondImageFormatError = "File size cannot exceed 2 MB";
                }
                return false;
            }
            return true;
        }
    }
}
