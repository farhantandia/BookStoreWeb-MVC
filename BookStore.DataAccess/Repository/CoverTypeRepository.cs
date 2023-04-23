using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDBContext _db;

        public CoverTypeRepository(ApplicationDBContext db):base(db)
        {
            _db = db;
        }

        public void Update(CoverType obj)
        {
           _db.Update(obj);
        }
    }
}
