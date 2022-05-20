using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers.abstractions
{
    public interface IDescarteLixoModel
    {
        Task<IEnumerable<TdescarteLixo>> getAll();
        Task<TdescarteLixo> getById(int? id);
        Task<int> post(DescarteLixoViewModel tgastos);
        Task<int> update(TdescarteLixo tgastos);
        Task<int> delete(int id);
        bool Exists(int id);
    }
}
