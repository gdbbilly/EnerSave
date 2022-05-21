using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultasMVC.Models
{
    public class TgastosEnergiaModel : ITgastosEnergiaModel
    {

        private readonly DbenersaveContext _context;

        public TgastosEnergiaModel(DbenersaveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TgastosEnergia>> getAllGastos()
        {
            return await _context.TgastosEnergia.ToListAsync();
        }
        public async Task<TgastosEnergia> getGastosById(int? id)
        {
            return await _context.TgastosEnergia
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<int> postGastosAgua(GastosEnergiaViewModel tgastosagua)
        {
            var gastosAgua = new TgastosEnergia();
            gastosAgua.Kwh = tgastosagua.Kwh;
            gastosAgua.Periodo = tgastosagua.Periodo;
            gastosAgua.UsuarioId = tgastosagua.UsuarioId;
            _context.Add(gastosAgua);
            return await _context.SaveChangesAsync();

        }
        public async Task<int> updateGastosAgua(TgastosEnergia tgastos)
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
        public async Task<int> deleteGastos(int id)
        {
            var tgastos = await _context.TgastosEnergia.FindAsync(id);
            _context.TgastosEnergia.Remove(tgastos);
            return await _context.SaveChangesAsync();
        }
        public bool gastosExists(int id)
        {
            return _context.TgastosEnergia.Any(e => e.Id == id);
        }

        public Task<int> postGastos(GastosEnergiaViewModel tgastos)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> updateGastos(TgastosEnergia tgastos)
        {
            throw new System.NotImplementedException();
        }

    }
}
