﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PM3.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // marks an entity as new
        void Add(T entity);
        // marks an entity as modified
        void Update(T entity);
        // marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        void Save();

        // get entity by ID
        T GetById(int id);
        T GetById(string id); // overload GetById for string keys

        // get entity using delegate
        T Get(Expression<Func<T, bool>> where);

        // get all entities of type T
        IEnumerable<T> GetAll();

        // get entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
