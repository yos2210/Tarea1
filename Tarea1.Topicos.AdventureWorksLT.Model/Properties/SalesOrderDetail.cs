using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.Model.Model
{
    public partial class SalesOrderDetail
    {


        [NotMapped]
        public decimal SalesOrderDetail_UnitDiscountAmount
        {
            get
            {
                double unitDiscount = 0.173;
                decimal unitPrice = this.UnitPrice;

                decimal descuentoUnitario = unitPrice * Convert.ToDecimal(unitDiscount);

                decimal resultado = descuentoUnitario;
                return resultado;
            }
            set { }
        }
        
        [NotMapped]
        public decimal SalesOrderDetail_TotalSinDesc
        {
            get
            {
                decimal unitPrice = this.UnitPrice;
                short quantity = this.OrderQty;
                

                decimal total = unitPrice * quantity;

                decimal resultado = total;
                return resultado;
            }
            set { }
        }
        
        [NotMapped]
        public decimal SalesOrderDetail_TotalDesc
        {
            get
            {
                
                double unitDiscount = 0.173;

                decimal totalDesc = SalesOrderDetail_TotalSinDesc * Convert.ToDecimal(unitDiscount);

                decimal resultado = totalDesc;
                return resultado;
            }
            set { }
        }

    }
}
