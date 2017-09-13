using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SistemaVales.Dao
{
    public class Conexion
    {
        private string _servidor;
        private string _usuario;
        private string _password;

        public string Servidor
        {
            get
            {
                return _servidor;
            }
            set
            {
                _servidor = "Data Source = " + value + ";";
            }
        }

        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = "user id=" + value + ";";
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = "password=" + value + ";";
            }
        }

        public OracleConnection conexion;
        private static OracleConnection con = new OracleConnection();

        public bool AbrirConexion()
        {
            try
            {
                string stringconexion = Servidor + Usuario + Password;

                conexion  = new OracleConnection(stringconexion);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public OracleConnection ObtenerConexion()
        {
            try
            {
                string stringconexion = Servidor + Usuario + Password;
                return new OracleConnection(stringconexion);
            }
            catch (Exception ex )
            {
                throw new ArgumentException("Error al leer la configuracion" + ex.Message);
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
