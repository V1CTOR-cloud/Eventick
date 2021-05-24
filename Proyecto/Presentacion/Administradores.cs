using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Eventick
{
    public class Administradores
    {
        private string usuario;        
        private string email;        
        private int cp;
        private string contraseña;
        private string localidad;

        public string Usuario { get { return usuario;} set { usuario = value; } }
        public string Email { get { return usuario; } set { usuario = value; } }
        public int Cp { get { return cp; } set { cp = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }
        public string Localidad { get { return localidad; }set { localidad = value; } }
        public Administradores()
        {

        }

        public Administradores(string usu, string correo, int codigo_postal, string clave)
        {
            usuario = usu;
            email = correo;
            cp = codigo_postal;
            contraseña = clave;
        }

        public static List<Administradores> ComprobarAdmin(MySqlConnection conexion, string nombre)
        {
            List<Administradores> admins = new List<Administradores>();
            string consulta = String.Format("SELECT * FROM admin WHERE nombre='{0}' OR email='{0}'", nombre);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Administradores admin = new Administradores();

                    admin.usuario = AdminLoginCache.Nombre = reader.GetString(0);
                    admin.email = AdminLoginCache.Email = reader.GetString(1);
                    admin.cp = AdminLoginCache.CP = reader.GetInt32(2);
                    admin.contraseña = reader.GetString(3);
                    admin.localidad = AdminLoginCache.Localidad = reader.GetString(4);
                    admins.Add(admin);
                }
            }
            reader.Close();
            return admins;
        }

        public static List<Administradores> ComprobarAdminPorEmail(MySqlConnection conexion, string email)
        {
            List<Administradores> admins = new List<Administradores>();
            string consulta = "";

            foreach (char caracter in email)
            {
                if (email.Length > 12)
                {
                    consulta = String.Format("SELECT * FROM admin WHERE email='{0}'", email);
                }
                else
                {
                    consulta = String.Format("SELECT * FROM admin WHERE nombre='{0}'", email);
                }
            }

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Administradores admin = new Administradores();

                    admin.usuario = AdminLoginCache.Nombre = reader.GetString(0);
                    admin.email = AdminLoginCache.Email = reader.GetString(1);
                    admin.cp = AdminLoginCache.CP = reader.GetInt32(2);
                    admin.contraseña = reader.GetString(3);
                    admin.localidad = AdminLoginCache.Localidad = reader.GetString(4);
                    admins.Add(admin);
                }
            }
            reader.Close();
            return admins;
        }

        public static string ComprobarAdminClave(MySqlConnection conexion, string nombre, string clave)
        {
            string contraseña = "";
            string consulta = String.Format("SELECT * FROM admin WHERE nombre='{0}' OR email='{0}' AND contrasenia='{1}'", nombre, clave);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Administradores admin = new Administradores();
                    admin.usuario = reader.GetString(0);
                    admin.email = reader.GetString(1);
                    admin.cp = reader.GetInt32(2);
                    admin.contraseña = reader.GetString(3);                    
                    contraseña = admin.contraseña;
                }
            }
            reader.Close();
            return contraseña;
        }


        public static int AgregarEvento(MySqlConnection conexion , Eventos ev,string name) // Pasar el evento cargado
        {
            int retorno;
            string consulta = String.Format("INSERT INTO evento (id, titulo, descripcion, localidad, duracion, tipo, precio,cp) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",ev.Id,ev.Titulo,ev.Descripcion,ev.Localidad,ev.Duracion,ev.Tipo,ev.Precio,ev.CP);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            consulta = String.Format("INSERT INTO adminevento VALUES ('{0}','{1}')", name, ev.Id);
            comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }

        public static int EliminarEvento(MySqlConnection conexion, string id)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM evento WHERE id='{0}'",id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static int AgregarActividad(MySqlConnection conexion, Actividad act,string name) // Pasar la actividad cargada
        {
            int retorno;
            string consulta = String.Format("INSERT INTO actividad (id, titulo, descripcion, localidad, distancia, circular, dificultad, duracion, tipo,cp) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", act.Id,act.Titulo, act.Descripcion, act.Localidad, act.Distancia, act.Circular, act.Dificultad, act.Duracion, act.Tipo,act.CP);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            consulta = String.Format("INSERT INTO adminactividad VALUES ('{0}','{1}')", name, act.Id);
            comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();


            return retorno;
        }

        public static int EliminarActividad(MySqlConnection conexion, string id)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM actividad WHERE id='{0}'", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }



        public int TotalActAdmin(MySqlConnection conexion)
        {
            int contador;

            String consulta = String.Format("SELECT COUNT(*) FROM adminactividad WHERE idadmin = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            contador = reader.GetInt32(0);
            reader.Close();
            return contador;

        }



        public int TotalEvAdmin(MySqlConnection conexion)
        {
            int contador;

            String consulta = String.Format("SELECT COUNT(*) FROM adminevento WHERE idadmin = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            contador = reader.GetInt32(0);
            reader.Close();
            return contador;

        }


        public List<Eventos> TotalEventosAdmin(MySqlConnection conexion)
        {
            List<Eventos> lista = new List<Eventos>();
            String consulta = String.Format("SELECT * FROM evento ev INNER JOIN adminevento ae ON ev.id=ae.idevento WHERE ae.idadmin = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())

                {
                Eventos act = new Eventos(reader.GetString(6), reader.GetInt32(9));
                act.Id = reader.GetString(0);
                act.Titulo = reader.GetString(1);
                act.Descripcion = reader.GetString(2);
                act.Localidad = reader.GetString(3);
                act.Duracion = Convert.ToDateTime(reader.GetString(4));
                act.Tipo = reader.GetInt32(5);
                act.TipoActividadEvento = reader.GetString(6);
                act.Precio = reader.GetDouble(7);
                act.CP = reader.GetInt32(9);
                lista.Add(act);
            }
            reader.Close();
            return lista;

        }

        public List<Actividad> TotalActividadesAdmin(MySqlConnection conexion)
        {
            List<Actividad> lista = new List<Actividad>();
            String consulta = String.Format("SELECT * FROM actividad ac INNER JOIN adminactividad aa ON ac.id=aa.idactividad WHERE aa.idadmin = '{0}'", usuario);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())

            {
                Actividad act = new Actividad(reader.GetString(1), reader.GetInt32(10));
                act.Id = reader.GetString(0);
                act.Titulo = reader.GetString(1);
                act.Descripcion = reader.GetString(2);
                act.Localidad = reader.GetString(3);
                act.Distancia = reader.GetDouble(4);
                act.Circular = reader.GetInt16(5);
                act.Dificultad = reader.GetString(6);
                act.Duracion = Convert.ToDateTime(reader.GetString(7));
                act.Tipo = reader.GetInt32(8);
                lista.Add(act);
            }
            reader.Close();
            return lista;

        }


        public void ModificarAdmin(MySqlConnection conexion)
        {
            string consulta = String.Format("UPDATE admin SET email='{0}',contrasenia='{1}' WHERE nombre='{2}'", email,contraseña,usuario);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();

        }



    }
}
