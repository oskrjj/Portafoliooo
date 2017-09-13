using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SistemasVales.Negocio
{
    public class Usuario
    {
        public bool AgregarUsuario(String _password, String _rut, String _tipoUsuario)
        {
            try
            {
                string conexion = "DATA SOURCE=localhost:1521/xe;USER ID=portafolio; Password=admin;";
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = conexion;
                connection.Open();
                OracleCommand query = new OracleCommand("INSERT INTO USUARIO VALUES('@PASSWORD' , '@RUT' , '@TIPO_USUARIO_ID')");
                query.BindByName = true;
                query.Parameters.Add(new OracleParameter("@PASSWORD",_password));
                query.Parameters.Add(new OracleParameter("@RUT", _rut));
                query.Parameters.Add(new OracleParameter("@RIPO_USUARIO_ID", _tipoUsuario));
                query.ExecuteNonQuery();
                connection.Close();
                
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
