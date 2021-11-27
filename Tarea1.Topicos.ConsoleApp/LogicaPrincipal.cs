using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.ConsoleApp
{
    public class LogicaPrincipal
    {

        public void GenerarConsultas()
        {
            //ListaFacturasPorNombreAproxCliente();
            ListaProductosDescontinuados();
            ListaProductosPorNombreModelo();
        }

        private void ListaFacturasPorNombreAproxCliente()
        {
            var nombreCliente = "ma";
            var servicio = new AdventureWorksLT.BL.Logica.Customer();
            var resultado = servicio.ListaFacturasPorNombreAproxCliente(nombreCliente);
            ImprimirListaFacturasPorNombreAproxCliente(resultado);
        }

        private void ImprimirListaFacturasPorNombreAproxCliente(IList<AdventureWorksLT.Model.Model.Customer> resultado)
        {

            System.Console.WriteLine("Consulta 1:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var customer in resultado)
            {
                System.Console.WriteLine($"Producto: {customer.FullName}");
            }
            System.Console.WriteLine("\n");
        }

        private void ListaProductosDescontinuados()
        {

            var servicio = new AdventureWorksLT.BL.Logica.Product();
            var resultado = servicio.ListaProductosDescontinuados();
            ImprimirListaProductosDescontinuados(resultado);

        }
        private void ImprimirListaProductosDescontinuados(IList<AdventureWorksLT.Model.Model.Product> resultado)
        {

            System.Console.WriteLine("Consulta 2:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Id: {product.ProductId} - Producto: {product.Name} ");
            }
            System.Console.WriteLine("\n");
        }

        private void ListaProductosPorNombreModelo()
        {
            var nombreProducto = "ma";
            var servicio = new AdventureWorksLT.BL.Logica.Product();
            var resultado = servicio.ListaProductosPorNombreModelo(nombreProducto);
            ImprimirListaProductosPorNombreModelo(resultado);

        }
        private void ImprimirListaProductosPorNombreModelo(IList<AdventureWorksLT.Model.Model.Product> resultado)
        {

            System.Console.WriteLine("Consulta 3:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                foreach (var salesOrderDetails in product.SalesOrderDetails)
                {
                    System.Console.WriteLine($"Orden: {salesOrderDetails.OrderQty} - Nombre: {product.Name}");
                }

            }
            System.Console.WriteLine("\n");
        }


    }


}
