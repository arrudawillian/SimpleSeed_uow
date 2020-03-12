using System.Threading.Tasks;
using seed2.Domain.Model;

namespace seed2.DAL.Interface
{
    public interface IUnidadeRepository : IRepositoryBase<Unidade>
    {
         Unidade GetUnidadeById(int id);
         Unidade[] GetAllUnidade();
    }
}