using Alamut.Data.Structure;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Infrastructure.Services.Contracts.Genericservice
{
    public interface IGenericService<T> where T : class
    {
        ServiceResult Create<TViewModel>(TViewModel newEntity) where TViewModel : class;

        ServiceResult Edit(int id, T editedEntity);

        ServiceResult Delete(int id);

        bool ExistById(int id);

        Task<List<TModel>> GetAll<TModel>(List<Expression<Func<TModel, bool>>> predicate, Func<IQueryable<TModel>, IOrderedQueryable<TModel>> order = null) where TModel : PageSettings;

        Task<TModel> GetByCondition<TModel>(Expression<Func<T, bool>> where = null) where TModel : class;


        Task<T> Find(int id);
    }
}
