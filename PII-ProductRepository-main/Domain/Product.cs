using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository2025.Domain
{
    public class Product
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        //se actualizó el tipo de dato de Precio a decimal para que no haya inconsistencia con la BD
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }
        public List<Ingredient>? Ingredients { get; set; } // se agrega un atributo "Lista" del tipo "Ingrediente"

        public override string ToString()
        {
            return Codigo + " - " + Nombre + " - " + Stock +"u. - $" + Precio;
        }
    }
}
