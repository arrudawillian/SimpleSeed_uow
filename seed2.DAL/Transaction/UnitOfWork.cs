using System;
using System.Collections.Generic;
using System.Text;
using seed2.DAL.Interface;
using seed2.DAL.Repository;
using seed2.Domain.Model;

namespace seed2.DAL.Transaction
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly seed2Context _context;

        public UnitOfWork(seed2Context context)
        {
            _context = context;
        }

        private IUnidadeRepository _unidadeRepository;

        public IUnidadeRepository unidadeRepository
        {
            get
            {
                if (_unidadeRepository == null)
                {
                    _unidadeRepository = new UnidadeRepository(_context);
                }
                return _unidadeRepository;
            }
        }

        public void commit()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
