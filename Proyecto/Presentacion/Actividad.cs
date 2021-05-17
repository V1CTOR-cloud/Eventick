using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Eventick
{
    public class Actividad : Elemento_a_ofrecer
    {
        private double distancia;
        private int circular;
        private string dificultad;

        public double Distancia { get { return distancia; } set { distancia = value; } }
        public int Circular { get {return circular; } set {circular = value; } }
        public string Dificultad { get{return dificultad; } set {dificultad = value; } }

        public Actividad()
        {

        }

        public Actividad(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip,double km,  int circulo, string dificil) : base(identificador,tittle,descrip,local,tiempo,tip)
        {
            distancia = km;
            circular = circulo;
            dificultad = dificil;
        }

        public static List<Actividad> CargarActividades(MySqlConnection conexion)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = "SELECT * FROM actividad";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                Actividad act = new Actividad();

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
    }
}
