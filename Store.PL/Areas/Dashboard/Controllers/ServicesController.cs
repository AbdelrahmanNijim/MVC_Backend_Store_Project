using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Store.DAL.Data;
using Store.DAL.Models;
using Store.PL.Areas.Dashboard.ViewModels;
using Store.PL.Helpers;

namespace Store.PL.Areas.Dashboard.Controllers
{
    
    [Authorize(Roles = " admin , superAdmin ") ] 
 
    [Area("Dashboard")]
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ServicesController( ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            
            ViewData["userName"] = "Abdelrahman Nijim";
            ViewBag.Email = "nijimabdelrahman@gmail.com";

            return View(mapper.Map<IEnumerable<ServicesVm>>(context.Services.ToList()));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServicesFormVm model)
        {
            if (!ModelState.IsValid) {

                return View(model);

            }
        
            model.Imagename = FilesSettings.uploadFiles(model.Image, "images");

            var service = mapper.Map<Services>(model);
            context.Add(service);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var service = context.Services.Find(id);
            if (service == null) { 
            return NotFound();
            
            }
            var serviceModel = mapper.Map<ServiceDetailsVm>(service);
            return View(serviceModel);
        }

    
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var service = context.Services.Find(id);
            if (service == null)
            {
                return RedirectToAction(nameof(Index));

            }
            FilesSettings.DeleteFiles(service.ImageName, "images");
            context.Services.Remove(service);
            context.SaveChanges();

            return Ok(new {message ="Service Deleted"});
           

           
        }

        public IActionResult Edit(int id) 
        { var service = context.Services.Find(id);
            if (service == null)
            {
             return NotFound();
            }

            var servicevm = mapper.Map<ServicesFormVm>(service);
            return View(servicevm);
        
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServicesFormVm vm)
        {
            var service = context.Services.Find(vm.id);
            if (service == null)
            {
                return NotFound();
            }

            if (vm.Image is null)
            {

                ModelState.Remove("Image");
                // vm.Imagename = service.ImageName;

            }
            else
            {
                FilesSettings.DeleteFiles(service.ImageName, "images");
                vm.Imagename = FilesSettings.uploadFiles(vm.Image, "images");

            }


            if (!ModelState.IsValid)
            {
               return View(vm);
            }
           
            
           




      
            mapper.Map(vm,service);
                context.SaveChanges();
            
            return RedirectToAction(nameof(Index));

        }



    }
}
