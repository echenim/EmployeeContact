using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.Business.Contracts;
using Portal.Domain.Models;
using Portal.Domain.Helper;
using Portal.Domain.ViewModels;

namespace Portal.Controllers
{
    public class WorkStationController : Controller
    {
        private readonly IDepartmentService _service;
        private readonly IPersonService _personService;

        public WorkStationController(IDepartmentService service, IPersonService personService)
        {
            _service = service;
            _personService = personService;
        }

        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);
            var department = new List<DepartmentViewModel>();
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            var data = !string.IsNullOrEmpty(searchString) ? _service.Get(s => s.Name.ToLower()
            .Contains(searchString.ToLower())) : _service.Get();

            foreach(var item in data)
            {
                department.Add(new DepartmentViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    ResourceCount = item.People.LongCount()
                });
            }
           
            return View("_list",department);
        }
        

        // GET: WorkStation/Create
        public ActionResult Add()
        {
            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);

            return View("_add");
        }

        // POST: WorkStation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name")] Departments entity)
        {
            var result = _service.Save(entity: entity);           
            if (result.Success) return RedirectToAction(nameof(Index));            
            return View("_add");
        }

        // GET: WorkStation/Edit/5
        public ActionResult Edit(long id)
        {
            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);

            var dataObj = _service.find(s => s.Id == id);
            return View("_edit",dataObj);
        }

        // POST: WorkStation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,Name")] Departments entity)
        {
            var result = _service.Edit(entity: entity);
            if (result.Success) return RedirectToAction(nameof(Index));
            return View("_edit", entity);
        }

        // GET: WorkStation/Delete/5
        public ActionResult Delete(long id)
        {
            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);

            var dataObj = _service.find(s => s.Id == id);
            return View("_delete", dataObj);
        }

        // POST: WorkStation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Departments entity)
        {
            var result = _service.Delete(entity: entity);
            if (result.Success) return RedirectToAction(nameof(Index));
            return View("_delete", entity);
        }

        // GET: WorkStation/Resource/5
        public ActionResult Resource(long id)
        {
            ViewBag.ControllerName = UtiOther.GetControllerName(this.ControllerContext);
            ViewBag.DepartmentName =id>0 ? _service.Get(s => s.Id == id).SingleOrDefault().Name.ToString():null;
            var dataObj =id>0 ? _personService.Get(s=>s.Departments.Id==id) :null;

            return View("_view", dataObj);
        }


    }
}