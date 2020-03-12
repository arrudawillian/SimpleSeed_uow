using System.Threading.Tasks;
using seed2.Domain.Model;

namespace seed2.BLL.Interface
{
    public interface IUnidadeService
    {
        Unidade GetUnidadeById(int id);
        Unidade[] GetAllUnidade();
    }
}