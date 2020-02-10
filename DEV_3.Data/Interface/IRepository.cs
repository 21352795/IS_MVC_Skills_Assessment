﻿using System;
using System.Linq;

namespace DEV_3.Interface
{
    public interface IRepository<TEntity> where TEntity:class 
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}
