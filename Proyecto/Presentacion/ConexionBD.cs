using MySql.Data.MySqlClient;

namespace Eventick
{
    public class ConexionBD
    {
        private MySqlConnection conexion;

        public MySqlConnection Conexion { get { return conexion; }}
        

        public ConexionBD()
        {
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=eventick;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string connectionstring = server + port + database + usuario + password;
                        
            conexion = new MySqlConnection(connectionstring);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)  
            {
                return false;                
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex) 
            {
                return false;
            }
        }

    }
}
