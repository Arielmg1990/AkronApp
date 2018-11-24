using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akron.Entidades.Home
{
    public class Home_Productonuevo
    {
        public int  PruductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string ImagenRuta { get; set; }
    }
}
