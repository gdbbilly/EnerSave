using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC.Models
{
    public class TdescarteLixoModel : IDescarteLixoModel
    {

        private readonly DbenersaveContext _context;

        public TdescarteLixoModel(DbenersaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TdescarteLixo>> getAll()
        {
            return await _context.TdescarteLixo.ToListAsync();
        }
        public async Task<TdescarteLixo> getById(int? id)
        {
            return await _context.TdescarteLixo
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> post(DescarteLixoViewModel tgastosagua)
        {
            var gastosAgua = new TdescarteLixo();
            gastosAgua.Peso = tgastosagua.Peso;
            gastosAgua.Organico = tgastosagua.Organico;
            gastosAgua.Reciclavel = tgastosagua.Reciclavel;
            gastosAgua.Periodo = tgastosagua.Periodo;
            gastosAgua.UsuarioId = tgastosagua.UsuarioId;
            _context.Add(gastosAgua);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> update(TdescarteLixo tgastos)
        {
            try
            {
                _context.Update(tgastos);
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<int> delete(int id)
        {
            var tgastos = await _context.TdescarteLixo.FindAsync(id);
            _context.TdescarteLixo.Remove(tgastos);
            return await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.TdescarteLixo.Any(e => e.Id == id);
        }
    }
}
