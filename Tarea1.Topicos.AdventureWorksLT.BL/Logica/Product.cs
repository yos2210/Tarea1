using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.BL.Logica
{
    public class Product
    {
        public IList<Model.Model.Product> ListaProductosDescontinuados()
        {
            IList<Model.Model.Product> resultado;
            using (var _contexto = new Model.Model.AdventureWorksLT2019Context())
            {
                resultado = _contexto.Products.Where(p => p.DiscontinuedDate == null).OrderBy(p => p.ListPrice).ToList();
            }
            return resultado;
        }

        public IList<Model.Model.Product> ListaProductosPorNombreModelo(String nombreProducto)
        {
            IList<Model.Model.Product> resultado;
            using (var _contexto = new Model.Model.AdventureWorksLT2019Context())
            {
                resultado = _contexto.Products.Include(p => p.SalesOrderDetails).Where(p => p.Name.Contains(nombreProducto)).OrderBy(p => p.ProductId).ToList();
            }
            return resultado;
        }
    }
}
