using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSM.Core.Domain.Base;
using GSM.Core.Domain.Games;
using GSM.Core.Repository;
using GSM.Core.Repository.IGenericRepository;
using GSM.Data.ORM;
using Microsoft.EntityFrameworkCore;

namespace GSM.Data.Repository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        public GameContext _context = null;
        public DbSet<T> table = null;
        public GenericRepository(GameContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

    }
}
