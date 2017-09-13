using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVales.Dao
{
    public class ProductoEnt
    {
        public string _idProducto { get; set; }
        public string _descripcionProducto { get; set; }
        public int _valorProducto { get; set; }
        public int _stockProducto { get; set; }
    }
}
