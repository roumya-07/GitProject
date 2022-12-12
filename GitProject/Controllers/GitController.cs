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
        public GitController(IService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAll());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DotNet dn)
        {
            try
            {
                if (dn == null)
                {
                    return View();
                }
                else
                {
                    await _service.Insert(dn);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DotNet dn)
        {
            try
            {
                if (dn == null)
                {
                    return View();
                }
                else
                {
                   await _service.Update(dn);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await _service.GetOne(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            
             await _service.Delete(id);                 
            return RedirectToAction("Index");
        }
    }
}
