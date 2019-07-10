using Hopeline.DataAccess.Entities.Base;
using Hopeline.DataAccess.Interfaces;
using Hopeline.DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Hopeline.DataAccess.Repositories
{
    public class Repository<T>:IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;
        private DbSet<T> _entities;
        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();
        }
        public bool delete(T obj)
        {
            try
            {
                //_entities.Remove(obj);
                //_dbContext.SaveChanges();
                _entities.Attach(obj);
                var tmp = _dbContext.Entry(obj);
                tmp.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

        public T insert(T obj)
        {
            try
            {
                _entities.Add(obj);
                _dbContext.Entry(obj).State = EntityState.Added;
                //_dbContext.SaveChanges();
                return obj;
            }
            catch
            {
                return null;
            }
            
        }

        public T update(T obj)
        {
            //var tmp = _entities.Attach(obj);
            //tmp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //_dbContext.SaveChanges();
            _entities.Attach(obj);
            var tmp = _dbContext.Entry(obj);
            tmp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return obj;
        }
        public string save()
        {
            try
            {
                _dbContext.SaveChanges();
                return "Added";
            }catch(Exception ex)
            {
                return ex.ToString();
            }
        }


    }
}
