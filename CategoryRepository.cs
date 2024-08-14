﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DataAccess.Data;
using WebApplication1.DataAccess.Repository.IRepository;
using WebApplication1.Models;

namespace WebApplication1.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(Category db)
        {
            _db.Categories.Update(db);
        }
    }
}
