using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVales.Dao
{
    public class DetalleEnt
    {
        public string _idDetalle { get; set; }
        public string _idProducto { get; set; }
        public string _descripcionProducto { get; set; }
        public int _valorDetalle { get; set; }
        public int _numeroBoleta { get; set; }  
    }
}
