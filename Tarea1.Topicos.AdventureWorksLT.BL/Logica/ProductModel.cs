using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.BL.Logica
{
    public class ProductModel
    {
        public IList<Model.Model.ProductModel> ListaProductosPorNombreModelo(String nombreModelo)
        {
            IList<Model.Model.ProductModel> resultado;
            using (var _contexto = new Model.Model.AdventureWorksLT2019Context())
            {
                resultado = _contexto.ProductModels.Include(p => p.Products).Where(p => p.Name.Contains(nombreModelo)).OrderBy(p => p.ProductModelId).ToList();
            }
            return resultado;
        }
    }
}
