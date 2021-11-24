using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.Model.Model
{
    
    public partial class SalesOrderHeader
    {
        [NotMapped]
        public int OrderDuration
        {
            get
            {
                DateTime orderDate = Convert.ToDateTime(this.OrderDate);
                DateTime shipDate = Convert.ToDateTime(this.ShipDate);

                TimeSpan difDates = shipDate - orderDate;
                int duration = difDates.Days;
                return duration;
            }
            set { }
        }
    }
}
