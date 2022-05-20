using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers.abstractions
{
    public interface ITgastosEnergiaModel
    {
        Task<IEnumerable<TgastosEnergia>> getAllGastos();
        Task<TgastosEnergia> getGastosById(int? id);
        Task<int> postGastos(GastosEnergiaViewModel tgastos);
        Task<int> updateGastos(TgastosEnergia tgastos);
        Task<int> deleteGastos(int id);
        bool gastosExists(int id);
    }
}
