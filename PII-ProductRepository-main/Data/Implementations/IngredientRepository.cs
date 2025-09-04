using Repository2025.Data.Helpers;
using Repository2025.Data.Interfaces;
using Repository2025.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository2025.Data.Implementations
{
    public class IngredientRepository : IIngredientRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAll()
        {
            List<Ingredient> lst = new List<Ingredient>();

            // Traer registros de la BD
            var dt = DataHelper.GetInstance().ExecuteSPQuery("SP_RECUPERAR_INGREDIENTES");

            // Mapear cada DataRow a un Ingredient
            foreach (DataRow row in dt.Rows)
            {
                Ingredient i = new Ingredient();
                i.Codigo = (int)row["codigo"];
                i.Nombre = (string)row["n_ingrediente"];
                i.Codigo_Producto = (int)row["codigo_producto"];
                i.Cantidad = (double)row["cantidad"];
                i.Unidad = (string)row["unidad"];

                lst.Add(i);
            }

            return lst;
        }

        public Ingredient? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}

