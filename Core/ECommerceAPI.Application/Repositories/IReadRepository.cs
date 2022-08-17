using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    //veri tabanından veri elde etmek için bu kullanılır. IQueryable= sorgu yapmak için direk veritabanında query e ekler.
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);//şarta uygun olan ilkini getir
        Task<T> GetByIdAsync(string id, bool tracking = true);// id uygun olanı getirecek
    }
}
