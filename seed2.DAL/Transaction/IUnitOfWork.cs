using seed2.DAL.Interface;
using seed2.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace seed2.DAL.Transaction
{
    public interface IUnitOfWork
    {
        IUnidadeRepository unidadeRepository { get; }
        void commit();
    }
}
