using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace Yummy.Domain
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity:class
    {
        private YummyDBEntities _context = null;

        public Repository()
        {
            _context = new YummyDBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }

        public TEntity Add(TEntity toCreate)
        {
            TEntity result = null;

            try
            {
                EntitySet.Add(toCreate);
                _context.SaveChanges();
                result = toCreate;
            }
            catch (Exception ex)
            {
                throw new Exception("Details error: ", ex);
            }

            return result;
        }

        public bool Delete(TEntity toDelete)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(toDelete);
                EntitySet.Remove(toDelete);
                result = _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Details error: ", ex);
            }

            return result;
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria)
        {
            List<TEntity> result = null;

            try
            {
                result = EntitySet.Where(criteria).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Details error: ", ex);
            }

            return result;
        }

        public List<TEntity> GetAllForGroupId(Expression<Func<TEntity, bool>> criteria)
        {
            List<TEntity> result = null;

            try
            {
                result = EntitySet.Where(criteria).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Details error: ", ex);
            }

            return result;
        }

        public TEntity GetForId(Expression<Func<TEntity, bool>> criteria)
        {
            TEntity result = null;
            try
            {
                result = EntitySet.FirstOrDefault(criteria);
            }
            catch (Exception ex)
            {
                throw new Exception("Details error: ", ex);
            }

            return result;
        }

        public bool Update(TEntity toUpdate)
        {
            bool result = false;

            try
            {
                EntitySet.Attach(toUpdate);
                _context.Entry<TEntity>(toUpdate).State = EntityState.Modified;
                result = _context.SaveChanges() > 0;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Class: {0}, Property: {1}, Error: {2}",
                            validationErrors.Entry.Entity.GetType().FullName,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }

                throw;
            }

            return result;
        }
    }
}