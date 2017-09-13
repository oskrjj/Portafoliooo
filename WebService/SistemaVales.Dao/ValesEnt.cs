using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVales.Dao
{
    public class ValesEnt
    {
        public string _codigoVale { get; set; }
        public string _empleadoRut { get; set; }
        public string _nombreEmpleado { get; set; }
        public string _hora { get; set; }
        public string _turno { get; set; }
        public int _valor { get; set; }
        public string _servicioID { get; set; }
        public string _descripcionServicio { get; set; }
    }
}
