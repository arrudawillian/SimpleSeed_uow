using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using seed2.DAL.Interface;
using seed2.Domain.Model;

namespace seed2.DAL.Repository
{
    public class UnidadeRepository : RepositoryBase<Unidade>, IUnidadeRepository
    {
        private readonly seed2Context _context;

        public UnidadeRepository(seed2Context context) : base(context)
        {
            _context = context;
        }

        public Unidade[] GetAllUnidade()
        {
            return _context.Unidades.ToArray();
        }

        public Unidade GetUnidadeById(int id)
        {
            return _context.Unidades.Where(_ => _.Id == id).FirstOrDefault();
        }
    }
}