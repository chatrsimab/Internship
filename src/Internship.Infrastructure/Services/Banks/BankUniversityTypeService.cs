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
    public class BankUniversityTypeService
    {
        private readonly ApplicationDbContext _context;
        private readonly Routine2Repository _routine2Repository;

        public BankUniversityTypeService(Routine2Repository routine2Repository, ApplicationDbContext context)
        {
            _context = context;
            _routine2Repository = routine2Repository;

        }

        public List<BankUniversityType> GetAll(BankUniversityTypeSearchViewModel search)
        {
            return _context.BankUniversityType
                .WhereIf(!string.IsNullOrEmpty(search.Term), q => q.Title.Contains(search.Term))
                .ToList();
        }


        public BankUniversityType GetById(int id)
        {
            return _context.BankUniversityType
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public ServiceResult<int> Create(BankUniversityType model)
        {
            _context.BankUniversityType.Add(model);
            _context.SaveChanges();
            var result = ServiceResult<int>.Okay(model.Id);
            return result;
        }

        public ServiceResult Edit(BankUniversityType vm)
        {

            _context.BankUniversityType.Update(vm);

            _context.SaveChanges();
            return ServiceResult<int>.Okay(vm.Id, "با موفقیت ویرایش شد");
        }

        public ServiceResult<int> DeleteById(int id)
        {
            var model = _context.BankUniversityType.Find(id);

            _context.Remove(model);
            _context.SaveChanges();

            var result = ServiceResult<int>.Okay(model.Id, "با موفقیت حذف شد");
            return result;
        }

    }
}
