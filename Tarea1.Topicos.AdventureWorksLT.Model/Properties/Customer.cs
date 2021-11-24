using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Topicos.AdventureWorksLT.Model.Model
{
    public partial class Customer
    {
        [NotMapped]
        public string FullName
        {
            get
            {
                var middleName = string.Empty;
                if (this.MiddleName != null)
                {
                    middleName = this.MiddleName + " ";
                }

                var firstName = this.FirstName + " ";
                var lastName = this.LastName;

                var resultado = $"{firstName}{middleName}{lastName}";
                return resultado;
            }
            set { }
        }

        [NotMapped]
        public string FullNameInvert
        {
            get
            {
                var middleName = string.Empty;
                if (this.MiddleName != null)
                {
                    middleName = this.MiddleName + " ";
                }

                var firstName = this.FirstName + " ";
                var lastName = this.LastName;

                var resultado = $"{lastName}, {firstName}{middleName}";
                return resultado;
            }
            set { }
        }

    }
}
