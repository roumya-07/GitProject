using GitProject.Models;
using GitProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Controllers
{
    public class GitController : Controller
    {
        private readonly IService _service;
        protected GitController(IService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DotNet dn)
        {
            try
            {
                if (dn == null)
                {
                    return View();
                }
                else
                {
                    _service.Insert(dn);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(DotNet dn)
        {
            try
            {
                if (dn == null)
                {
                    return View();
                }
                else
                {
                    _service.Update(dn);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public IActionResult Details(int id)
        {
            return View(_service.GetOne(id));
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
