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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDBContext _db;

        public CompanyRepository(ApplicationDBContext db):base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
           _db.Update(obj);
        }
    }
}
