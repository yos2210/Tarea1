using System;
using System.Collections.Generic;

#nullable disable

namespace Tarea1.Topicos.AdventureWorksLT.Model.Model
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }

        public int ProductModelId { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
