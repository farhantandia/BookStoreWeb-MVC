using BookStore.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _db;
        internal DbSet<T> dBSet;
        
        public Repository(ApplicationDBContext db)
        {
            _db = db;
            this.dBSet = _db.Set<T>();

        }
        public void Add(T entity)
        {
            dBSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dBSet;
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dBSet;

            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dBSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dBSet.RemoveRange();
        }
    }
}
