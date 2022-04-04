using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Entidades;
using ProyectoFinal.IEntidades;

namespace ProyectoFinal.IRepositories;

public interface IGenericRepository<TEntity> where TEntity : class, ICreatedUpdated
{
    IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "");
    TEntity GetById(object id);

    void Add(TEntity entity, int? id);
    void Insert(TEntity entity);
    void Delete(object? id);
    void Delete(TEntity entityToDelete);
    void Update(TEntity entityToUpdate);
}

// public interface IGenericRepository<T> where T : class
// {
//     Task<IEnumerable<T>> All();
//     Task<T> GetById(Guid id);
//     Task<bool> Add(T entity);
//     Task<bool> Delete(int id);
//     Task<bool> Upsert(T entity);
//     Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
// }