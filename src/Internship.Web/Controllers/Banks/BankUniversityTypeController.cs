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
    public class BankUniversityTypeController : Controller
    {
        private readonly BankUniversityTypeService _bankUniversityTypeRepository;

        public BankUniversityTypeController(BankUniversityTypeService BankUniversityTypeService)
        {
            _bankUniversityTypeRepository = BankUniversityTypeService;
        }
        public IActionResult Index(BankUniversityTypeSearchViewModel search)
        {
            var data = _bankUniversityTypeRepository.GetAll(search);
            var model = new SearchCriteriaPageModel<List<BankUniversityType>, BankUniversityTypeSearchViewModel>(data, search);
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BankUniversityType vm)
        {
            var result = _bankUniversityTypeRepository.Create(vm);
            TempData.AddResult(result);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = _bankUniversityTypeRepository.GetById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BankUniversityType vm)
        {
            var result = _bankUniversityTypeRepository.Edit(vm);
            TempData.AddResult(result);

            return Utility.CloseAndRedirect(Url.Action(nameof(Index)));
        }

        public IActionResult Delete(int id)
        {
            var model = _bankUniversityTypeRepository.DeleteById(id);
            TempData.AddResult(model);
            return RedirectToAction("Index");
        }
    }
}