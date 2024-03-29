﻿using HamburgerProject.AppDbContext;
using HamburgerProject.Entity.Abstract;
using HamburgerProject.Repositories.Abstract;
using System.Linq.Expressions;

namespace HamburgerProject.Repositories.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext db;
        public GenericRepository(ApplicationDbContext applicationDb)
        {
            db = applicationDb;
        }
        public bool Add(T entity)
        {

            db.Set<T>().Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            return db.SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public bool Update(T entity)
        {
            db.Set<T>().Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
