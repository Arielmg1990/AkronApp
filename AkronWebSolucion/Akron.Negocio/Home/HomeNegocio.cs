using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akron.Entidades.Home;
using Akron.BaseDatos;

namespace Akron.Negocio
{
    public class HomeNegocio
    {
        public List<Home_Productonuevo> ObtenerProductosNuevos()
        {
            // Variable que se devuelve con el listado de productos nuevos
            var _listaProductos = new List<Home_Productonuevo>();
            // Abrimos conexion a BD para obtener los productos
            using (var bd = new AkronEntities())
            {
                //var _produtos = bd.Productos.ToList();
                for (var i = 0; i < 9; i++)
                {
                    var _productoNuevo = new Home_Productonuevo();
                    _productoNuevo.PruductoID = i;
                    _productoNuevo.Nombre = "Akron " + i;
                    _productoNuevo.Descripcion = "Descripcion del producto "+i;
                    _productoNuevo.Precio = 24 + i;
                    _productoNuevo.ImagenRuta = string.Empty;

                    // Agregamos al objeto tipo Lista el objeto llenado
                    _listaProductos.Add(_productoNuevo);
                }
            }
            return _listaProductos;
        }

        public List<Home_Productonuevo> ObtenerProductosDestacados()
        {
            // Variable que se devuelve con el listado de productos nuevos
            var _listaProductos = new List<Home_Productonuevo>();
            // Abrimos conexion a BD para obtener los productos
            using (var bd = new AkronEntities())
            {
                //var _produtos = bd.Productos.ToList();
                for (var i = 0; i < 9; i++)
                {
                    var _productoNuevo = new Home_Productonuevo();
                    _productoNuevo.PruductoID = i;
                    _productoNuevo.Nombre = "Akron " + i;
                    _productoNuevo.Descripcion = "Descripcion del producto " + i;
                    _productoNuevo.Precio = 24 + i;
                    _productoNuevo.ImagenRuta = string.Empty;

                    // Agregamos al objeto tipo Lista el objeto llenado
                    _listaProductos.Add(_productoNuevo);
                }
            }
            return _listaProductos;
        }
    }
}
