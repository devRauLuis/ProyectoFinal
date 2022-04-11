using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.BLL;

public class GenericBLL<TEntity> where TEntity : class, ICreatedUpdated, IIdentifiable
{
    private ApplicationDbContext context;
    private DbSet<TEntity> dbSet;
    private readonly ILogger _logger;

    protected GenericBLL(ApplicationDbContext context, ILogger logger)
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

    public virtual TEntity? GetById(int? id)
    {
        // IQueryable<TEntity> query = dbSet;
        // foreach (var includeProperty in includeProperties.Split
        //              (new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
        // {
        //     query = query.Include(includeProperty);
        // }
        //
        // // return dbSet.Find(id);
        // return query.AsNoTracking().FirstOrDefault(x => x.Id == id);
        var found = dbSet.Find(id);
        context.Entry(found).State = EntityState.Detached;
        return found;
    }

    public virtual void Add(TEntity entity, int? id)
    {
        // var found = dbSet.Find(id);
        // bool exists = found != = null;
        var exists = id != null && GetById(id) != null;
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