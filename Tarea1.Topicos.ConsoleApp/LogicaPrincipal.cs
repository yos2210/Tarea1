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
            
            ListaProductosDescontinuados();
            ListaProductosPorNombreModelo();
            ListaFacturasPorNombreAproxCliente();
            ListaOrdenesConDetalleProducto();
        }

        private void ListaFacturasPorNombreAproxCliente()
        {
            var nombreCliente = "an";
            var servicio = new AdventureWorksLT.BL.Logica.Customer();
            var resultado = servicio.ListaFacturasPorNombreAproxCliente(nombreCliente);
            ImprimirListaFacturasPorNombreAproxCliente(resultado);
        }

        private void ImprimirListaFacturasPorNombreAproxCliente(IList<AdventureWorksLT.Model.Model.Customer> resultado)
        {

            System.Console.WriteLine("Consulta 3:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var customer in resultado)
            {
                foreach (var sale in customer.SalesOrderHeaders)
                {   
                        System.Console.WriteLine($"Cliente: {customer.FullName} - Id Venta: {sale.SalesOrderId}");           
                }
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

            System.Console.WriteLine("Consulta 1:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                System.Console.WriteLine($"Id: {product.ProductId} - Producto: {product.Name} - Precio: {product.ListPrice}");
            }
            System.Console.WriteLine("\n");
        }

        private void ListaProductosPorNombreModelo()
        {
            var nombreModelo = "short";
            var servicio = new AdventureWorksLT.BL.Logica.ProductModel();
            var resultado = servicio.ListaProductosPorNombreModelo(nombreModelo);
            ImprimirListaProductosPorNombreModelo(resultado);

        }
        private void ImprimirListaProductosPorNombreModelo(IList<AdventureWorksLT.Model.Model.ProductModel> resultado)
        {

            System.Console.WriteLine("Consulta 2:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var productModel in resultado)
            {
                foreach (var product in productModel.Products)
                {
                    System.Console.WriteLine($"Producto: {product.Name} - Modelo: {productModel.Name}");
                }

            }
            System.Console.WriteLine("\n");
        }

        private void ListaOrdenesConDetalleProducto()
        {
            var nombreProducto = "rear";
            var servicio = new AdventureWorksLT.BL.Logica.Product();
            var resultado = servicio.ListaOrdenesConDetalleProducto(nombreProducto);
            ImprimirListaOrdenesConDetalleProducto(resultado);

        }
        private void ImprimirListaOrdenesConDetalleProducto(IList<AdventureWorksLT.Model.Model.Product> resultado)
        {

            System.Console.WriteLine("Consulta 4:\n");
            if (resultado == null)
            {
                System.Console.WriteLine("Lista sin elementos");
                return;
            }
            foreach (var product in resultado)
            {
                foreach (var sale in product.SalesOrderDetails)
                {
                    System.Console.WriteLine($"Orden: {sale.SalesOrderId} - Producto: {product.Name}");
                }

            }
            System.Console.WriteLine("\n");
        }

    }


}
