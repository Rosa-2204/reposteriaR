using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposteriaR.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pastel tres leches";
            producto1.Precio = 350;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pastel helado de chocolate";
            producto2.Precio = 300;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pastel de caramelo";
            producto3.Precio = 250;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);


            return listadeProductos;
        }
    }
}
