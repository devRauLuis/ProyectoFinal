using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.Repositories;

public class GenericRepository<TEntity> where TEntity : class, ICreatedUpdated
{
    internal ApplicationDbContext context;
    internal DbSet<TEntity> dbSet;
    public readonly ILogger _logger;

    public GenericRepository(ApplicationDbContext context, ILogger logger)
    {
        this.context = context;
        this.dbSet = context.Set<TEntity>();
        _logger = logger;
    }

    public virtual IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
                     (new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        return orderBy != null ? orderBy(query).ToList() : query.ToList();
    }

    public virtual TEntity? GetById(object? id)
    {
        return dbSet.Find(id);
    }

    public virtual void Add(TEntity entity, int? id)
    {
        var exists = GetById(id) != null;
        if (exists)
        {
            entity.ActualizadoEn = DateTime.Now;
            Update(entity);
        }
        else
        {
            entity.CreadoEn = DateTime.Now;
            entity.ActualizadoEn = DateTime.Now;
            Insert(entity);
        }
    }

    public virtual void Insert(TEntity entity)
    {
        dbSet.Add(entity);
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);
        context.Entry(entityToUpdate).State = EntityState.Modified;
    }

    public virtual void Delete(object? id)
    {
        TEntity entityToDelete = dbSet.Find(id);
        Delete(entityToDelete);
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (context.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }
}


// public class GenericRepository<T> : IGenericRepository<T> where T : class
// {
//   
//     
//     protected ApplicationDbContext context;
//     internal DbSet<T> dbSet;
//     public readonly ILogger _logger;
//
//     public GenericRepository(
//         ApplicationDbContext context,
//         ILogger logger)
//     {
//         this.context = context;
//         this.dbSet = context.Set<T>();
//         _logger = logger;
//     }
//
//     public virtual async Task<T> GetById(Guid id)
//     {
//         return await dbSet.FindAsync(id);
//     }
//
//     public virtual async Task<bool> Add(T entity)
//     {
//         await dbSet.AddAsync(entity);
//         return true;
//     }
//
//     public virtual Task<bool> Delete(int id)
//     {
//         throw new NotImplementedException();
//     }
//
//     public virtual Task<IEnumerable<T>> All()
//     {
//         throw new NotImplementedException();
//     }
//
//     public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
//     {
//         return await dbSet.Where(predicate).ToListAsync();
//     }
//
//     public virtual Task<bool> Upsert(T entity)
//     {
//         throw new NotImplementedException();
//     }
// }