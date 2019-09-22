using Alamut.Data.Linq;
using Alamut.Data.Paging;
using Alamut.Data.Sql;
using Alamut.Data.Structure;
using Alamut.Helpers.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Internship.Core.DomainModels.DTO.Routine2;
using Internship.Core.DomainModels.DTO.Test;
using Internship.Core.DomainModels.Entity.Banks;
using Internship.Core.DomainModels.SSOT;
using Internship.Core.DomainModels.ViewModel.Banks;
using Internship.Core.DomainModels.ViewModel.Routine2;
using Internship.Core.DomainModels.ViewModel.Test;
using Internship.Infrastructure.DataLayer.Context;
using Internship.Infrastructure.Services.Routine2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Infrastructure.Services.Test
{
    public class BankUniversityNameService
    {
        private readonly ApplicationDbContext _context;

        public BankUniversityNameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IPaginated<BankUniversityName> GetAll(BankUniversityNameSearchViewModel search, int id)
        {
            var model = _context.BankUniversityName
                .Where(p => p.BankUniversityTypeId == id)
                .WhereIf(!string.IsNullOrEmpty(search.Term), q => q.Title.Contains(search.Term))
                .ToPaginated(new PaginatedCriteria(search.Page, search.PageSize));

            return model;
        }


        public BankUniversityName GetById(int id)
        {
            return _context.BankUniversityName
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public ServiceResult<int> Create(BankUniversityName model)
        {
            _context.BankUniversityName.Add(model);
            _context.SaveChanges();
            var result = ServiceResult<int>.Okay(model.Id);
            return result;
        }

        public ServiceResult Edit(BankUniversityName vm)
        {
            //var data = _context.BankUniversityName.FirstOrDefault(q => q.Id == vm.Id);
            //Mapper.Map(vm, data);
            _context.BankUniversityName.Update(vm);

            _context.SaveChanges();
            return ServiceResult<int>.Okay(vm.Id, "با موفقیت ویرایش شد");
        }

        public ServiceResult<int> DeleteById(int id)
        {
            var model = _context.BankUniversityName.Find(id);

            _context.Remove(model);
            _context.SaveChanges();

            var result = ServiceResult<int>.Okay(model.Id, "با موفقیت حذف شد");
            return result;
        }

    }
}
