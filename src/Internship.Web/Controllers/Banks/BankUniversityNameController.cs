using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alamut.Data.Paging;
using AutoMapper;
using Internship.Core.DomainModels.DTO;
using Internship.Core.DomainModels.DTO.Test;
using Internship.Core.DomainModels.Entity.Banks;
using Internship.Core.DomainModels.SSOT;
using Internship.Core.DomainModels.ViewModel.Banks;
using Internship.Infrastructure.Services.Test;
using Internship.Web.Helpers;
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

        public async Task<IActionResult> Index(BankUniversityNameSearchViewModel search, int id)
        {
            var conditions = new ConditionHelper<TestSummeryDTO>();

            if (search.Term!=null)
                conditions.AddCondition(p=>p.Title.Contains(search.Term));


            var data =await _bankUniversityNameRepository.GetAll<TestSummeryDTO>(conditions.GetConditionList());

            var model = new SearchCriteriaPageModel<List<TestSummeryDTO>, BankUniversityNameSearchViewModel>(data, search);
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
            var model = _bankUniversityNameRepository.GetByCondition<TestSummeryDTO>(p=>p.Id==id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BankUniversityName vm)
        {
            var entity = new BankUniversityName();
            Mapper.Map(vm, entity);

            var result = _bankUniversityNameRepository.Edit(vm.Id, entity);
            TempData.AddResult(result);
            return RedirectToAction("Index" , new { id = vm.BankUniversityTypeId });
        }

        public IActionResult Delete(int id)
        {
            var data = _bankUniversityNameRepository.GetByCondition<TestSummeryDTO>(p => p.Id == id);
            var model = _bankUniversityNameRepository.Delete(id);
            TempData.AddResult(model);
            return RedirectToAction("Index", new { id = id });
        }
    }
}