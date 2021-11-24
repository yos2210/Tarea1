using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.Model.Model
{
    public partial class Product
    {
        [NotMapped]
        public int ProductSellTime
        {
            get
            {
                DateTime sellStartDate = Convert.ToDateTime(this.SellStartDate);
                DateTime sellEndDate = Convert.ToDateTime(this.SellEndDate);

                TimeSpan difDates = sellStartDate - sellEndDate;
                int sellTime = difDates.Days;
                return sellTime;
            }
            set { }
        }
    }
}
