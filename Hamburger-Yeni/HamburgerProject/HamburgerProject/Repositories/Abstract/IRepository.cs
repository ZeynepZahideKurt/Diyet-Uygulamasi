﻿using System.Linq.Expressions;

namespace HamburgerProject.Repositories.Abstract
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
    }
}
