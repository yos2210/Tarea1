using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.BL.Logica
{
    public class Customer
    {
        public IList<Model.Model.Customer> ListaFacturasPorNombreAproxCliente(String nombreCliente)
        {
            IList<Model.Model.Customer> resultado;
            using (var _contexto = new Model.Model.AdventureWorksLT2019Context())
            {
                resultado = _contexto.Customers.Include(c => c.SalesOrderHeaders).Where(p => p.FullName.Contains(nombreCliente)).OrderBy(p => p.CustomerId).ToList();
            }
            return resultado;
        }
    }
}
