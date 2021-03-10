using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GSM.Core.Domain.Base;

namespace GSM.Core.Repository.IGenericRepository
{
    public interface IGenericRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
