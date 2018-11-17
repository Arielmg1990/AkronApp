using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akron.BaseDatos;

namespace Akron.Negocio.Home
{
    public class HomeNegocio
    {
        public int TestDemo()
        {
            using (var bd = new AkronEntities())
            {
                var _tabla = bd.Productos;

            }
            return 5;
        }
    }
}
