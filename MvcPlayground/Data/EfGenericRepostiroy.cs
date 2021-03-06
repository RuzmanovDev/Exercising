﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Data
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public EfGenericRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        public IQueryable<T> All
        {
            get
            {
                return this.DbSet;
            }
        }

        protected DbContext Context { get; private set; }

        protected DbSet<T> DbSet { get; private set; }

        public void Add(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Added;
        }

        public void AddOrUpdate(T entity)
        {
            this.Context.Set<T>().AddOrUpdate(entity);
        }

        public void Delete(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Deleted;
        }

        public IEnumerable<T> GetAll()
        {
            return this.DbSet.ToList();
        }

        public IEnumerable<T1> GetAll<T1>(Expression<Func<T, bool>> filterExpression, Expression<Func<T, T1>> selectExpression)
        {
            IQueryable<T> result = this.DbSet;

            if (filterExpression != null)
            {
                result = result.Where(filterExpression);
            }

            if (selectExpression != null)
            {
                return result.Select(selectExpression).ToList();
            }
            else
            {
                return result.OfType<T1>().ToList();
            }
        }

        public IEnumerable<T1> GetAll<T1>(
            Expression<Func<T, bool>> filterExpression,
            Expression<Func<T, T1>> selectExpression,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> result = this.DbSet;

            if (includes != null)
            {
                result = includes.Aggregate(result, (current, include) => current.Include(include));
            }

            if (filterExpression != null)
            {
                result = result.Where(filterExpression);
            }

            if (selectExpression != null)
            {
                return result.Select(selectExpression).ToList();
            }
            else
            {
                return result.OfType<T1>().ToList();
            }
        }

        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public void Update(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public T GetFirst(Expression<Func<T, bool>> filterExpression)
        {
            var foundEntity = this.DbSet.FirstOrDefault(filterExpression);
            return foundEntity;
        }

        public T GetFirst(Expression<Func<T, bool>> filterExpression, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> result = this.DbSet;

            if (includes != null)
            {
                result = includes.Aggregate(result, (current, include) => current.Include(include));
            }

            return result.OfType<T>().FirstOrDefault(filterExpression);
        }
    }
}
