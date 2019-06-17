using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portal.Business.Contracts;
using Portal.Domain.Models;
using Portal.Domain.ViewModels;
using Portal.Domain.Helper;

namespace Portal.Controllers
{
    public class ResourcesController : Controller
    {
        private readonly IPersonService _service;
        private readonly IDepartmentService _departmentService;

        public ResourcesController(IPersonService service, IDepartmentService departmentService)
        {
            _service = service;
            _departmentService = departmentService;
        }

        public ActionResult Index(string searchString)
        {
            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);
           
            var datacollection =!string.IsNullOrEmpty(searchString) 
                ? _service.Get(s=>s.Name.ToUpper().Contains(searchString.ToUpper())).OrderBy(s=>s.Name)
                : _service.Get().OrderBy(s=>s.Name);

         
            return View("_list", datacollection);
        }


        // GET: WorkStation/Create
        public ActionResult Add()
        {

            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);

            var personObj = new PersonWriteViewModels();


            #region gender
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Select Sex",
                Value = ""
            });
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Female",
                Value = "Female"
            });
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Male",
                Value = "Male"
            });

            #endregion

            #region departments
            var departments = _departmentService.Get();
            foreach (var item in departments)
            {
                personObj.AvailableDepartment.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }

            #endregion
            return View("_add",personObj);
        }

        // POST: WorkStation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(PersonWriteViewModels entity)
        {
            var result = _service.Save(entity: entity);
            if (result.Success) return RedirectToAction(nameof(Index));
            return View("_add");
        }

        // GET: WorkStation/Edit/5
        public IActionResult Edit(long id)
        {

            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);

            var personObj = _service.find(s=>s.Id==id);
            #region gender
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Select Sex",
                Value = ""
            });
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Female",
                Value = "Female"
            });
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Male",
                Value = "Male"
            });

            #endregion
            #region departments
            var departments = _departmentService.Get();
            foreach (var item in departments)
            {
                personObj.AvailableDepartment.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }

            #endregion

            return View("_edit", personObj);
        }

        // POST: WorkStation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PersonWriteViewModels entity)
        {
            var result = _service.Edit(entity: entity);
            if (result.Success) return RedirectToAction(nameof(Index));
            return View("_edit", entity);
        }

        // GET: WorkStation/Delete/5
        public ActionResult Delete(long id)
        {

            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);

            var personObj = _service.find(s => s.Id == id);
            #region gender
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Select Sex",
                Value = ""
            });
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Female",
                Value = "Female"
            });
            personObj.AvailableGender.Add(new SelectListItem
            {
                Text = "Male",
                Value = "Male"
            });

            #endregion
            #region departments
            var departments = _departmentService.Get();
            foreach (var item in departments)
            {
                personObj.AvailableDepartment.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }

            #endregion

            return View("_delete", personObj);
        }

        //POST: WorkStation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(PersonWriteViewModels entity)
        {
            var result = _service.Delete(entity: entity);
            if (result.Success) return RedirectToAction(nameof(Index));
            return View("_delete", entity);
        }
    }
}