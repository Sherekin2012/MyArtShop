﻿using MyArtShop.Core.Models;
using MyArtShop.Core.Contracts;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.Design;

namespace MyArtShopDataAccess.SQL
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal DataContext context;
        internal DbSet<T> dbSet;


        public SQLRepository(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IQueryable<T> Collection()
        {
            return dbSet;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Delete(string Id)
        {
            var t = Find(Id);
            if (context.Entry(t).State == EntityState.Detached)
                dbSet.Attach(t);

            dbSet.Remove(t);
        }
         
        public T Find(string Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T t)
        {
            dbSet.Add(t);
        }

        public void Update(T t)
        {
            dbSet.Attach(t);
            context.Entry(t).State = EntityState.Modified;
            
        }
    }
}
