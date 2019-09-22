using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alamut.Data.Paging;
using Internship.Core.DomainModels.DTO;
using Internship.Core.DomainModels.Entity.Banks;
using Internship.Core.DomainModels.SSOT;
using Internship.Core.DomainModels.ViewModel.Banks;
using Internship.Infrastructure.Services.Test;
using Microsoft.AspNetCore.Mvc;
using Research.City.Admin.Toolkit;

namespace Internship.Web.Controllers.Banks
{
    public class BankUniversityNameController : Controller
    {
        private readonly BankUniversityNameService _bankUniversityNameRepository;

        public BankUniversityNameController(BankUniversityNameService BankUniversityNameService)
        {
            _bankUniversityNameRepository = BankUniversityNameService;
        }

        public IActionResult Index(BankUniversityNameSearchViewModel search, int id)
        {
            var data = _bankUniversityNameRepository.GetAll(search, id);
            var model = new SearchCriteriaPageModel<IPaginated<BankUniversityName>, BankUniversityNameSearchViewModel>(data, search);
            ViewBag.Id = id;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BankUniversityName vm)
        {
            var result = _bankUniversityNameRepository.Create(vm);
            TempData.AddResult(result);

            return RedirectToAction("Index", new { id = vm.BankUniversityTypeId});
        }

        public IActionResult Edit(int id)
        {
            var model = _bankUniversityNameRepository.GetById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BankUniversityName vm)
        {

            var result = _bankUniversityNameRepository.Edit(vm);
            TempData.AddResult(result);
            return RedirectToAction("Index" , new { id = vm.BankUniversityTypeId });
        }

        public IActionResult Delete(int id)
        {
            var data = _bankUniversityNameRepository.GetById(id);
            var model = _bankUniversityNameRepository.DeleteById(id);
            TempData.AddResult(model);
            return RedirectToAction("Index", new { id = data.BankUniversityTypeId });
        }
    }
}