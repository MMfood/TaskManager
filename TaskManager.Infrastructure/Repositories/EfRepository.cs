﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Interfaces;
using TaskManager.Infrastructure.Data;

namespace TaskManager.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T>
        where T : class
    {
        private readonly WorkContext context;

        public EfRepository(WorkContext context)
        {
            this.context = context;
        }

        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.Entry(entity).State = EntityState.Unchanged;
            context.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;

            context.SaveChanges();
        }

        public T Get(string id)
        {
            var entity = context.Set<T>().Find(id);

            if (entity != null)
            {
                context.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public T Get(ISpecification<T> specification)
        {
            return ApplySpecification(context.Set<T>(), specification).FirstOrDefault();
        }

        public IList<T> List()
        {
            return context.Set<T>().AsNoTracking().ToList();
        }

        public IList<T> List(ISpecification<T> specification)
        {
            return ApplySpecification(context.Set<T>(), specification).ToList();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        private IQueryable<T> ApplySpecification(IQueryable<T> source, ISpecification<T> specification)
        {
            var result = specification.Apply(source);

            foreach (var include in specification.Includes)
            {
                result = result.Include(include);
            }

            return result.AsNoTracking();
        }
    }
}