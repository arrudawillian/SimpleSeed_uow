using System.Threading.Tasks;
using seed2.BLL.Interface;
using seed2.DAL.Transaction;
using seed2.Domain.Model;

namespace seed2.BLL.Service
{
    public class UnidadeService : IUnidadeService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public UnidadeService(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public Unidade[] GetAllUnidade()
        {
            return _UnitOfWork.unidadeRepository.GetAllUnidade();
        }

        public  Unidade GetUnidadeById(int id)
        {
            return _UnitOfWork.unidadeRepository.GetUnidadeById(id);
        }
    }
}