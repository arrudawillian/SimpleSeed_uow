using Microsoft.EntityFrameworkCore;
using seed2.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace seed2.DAL.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        private readonly seed2Context _context;

        DbSet<T> _DbSet;

        public RepositoryBase(seed2Context context)
        {
            _context = context;
            _DbSet = _context.Set<T>();
        }
        public IEnumerable<T> GetTudo(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _DbSet.Where(predicate);
            }
            return _DbSet.AsEnumerable();
        }
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.FirstOrDefault(predicate);
        }
        public void Adicionar(T entity)
        {
            _DbSet.Add(entity);
        }
        public void Atualizar(T entity)
        {
            _DbSet.Update(entity);
        }
        public void Deletar(T entity)
        {
            _DbSet.Remove(entity);
        }
        public int Contar()
        {
            return _DbSet.Count();
        }
    }
}
