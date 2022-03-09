using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IReceta
    {
        Task<IList<Receta>> getAll();
        Task<Receta> getById(string id);
        Task saveOne(Receta receta);
        Task deleteOne(string id);
        Task updateOne(Receta receta);
    }
}
