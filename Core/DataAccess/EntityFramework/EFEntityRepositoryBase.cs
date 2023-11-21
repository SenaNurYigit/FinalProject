using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //New'leme işlemini using içerisine yazmamızın mantığı garbage collector sayesinde veritabanıyla ilgili işlem bitince hafızayı temizler. Bu sayede hafızayı verimli kullanmış oluruz.
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //New'leme işlemini using içerisine yazmamızın mantığı garbage collector sayesinde veritabanıyla ilgili işlem bitince hafızayı temizler. Bu sayede hafızayı verimli kullanmış oluruz.
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //New'leme işlemini using içerisine yazmamızın mantığı garbage collector sayesinde veritabanıyla ilgili işlem bitince hafızayı temizler. Bu sayede hafızayı verimli kullanmış oluruz.
            {
                var updatetedEntity = context.Entry(entity);
                updatetedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
