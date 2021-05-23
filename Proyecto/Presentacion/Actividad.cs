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

        //AÑADIDO (VF):
        static int numActividad = 0;
        private bool aPie;
        private string tipoActividad;
        private int Cp;


        public double Distancia { get { return distancia; } set { distancia = value; } }
        public int Circular { get {return circular; } set {circular = value; } }
        public string Dificultad { get{return dificultad; } set {dificultad = value; } }

        //AÑADIDO(VF):
        public int NumActividad { get { return numActividad; } }
        public bool APie { get { return aPie; } set { aPie = value; } }
        public string TipoActividad { get { return tipoActividad; } set { tipoActividad = value; } }
        public int CP { get { return Cp; } set { Cp = value; } }


        public Actividad() { }
        public Actividad(string tipoact,int codigo)
        {
            CP = codigo;
            numActividad++;

                if (tipoact == "SENDERISMO")
                {
                    Id = CP + "A" + "01" + numActividad;

                }
                else if (tipoact == "ANDAR")
                {
                    Id = CP + "A" + "02" + numActividad;

                }
                else if (tipoact == "CORRER")
                {
                    Id = CP + "A" + "03" + numActividad;

                }
                else if (tipoact == "CAMINATA")
                {
                    Id = CP + "A" + "04" + numActividad;
                }

        }

        public Actividad(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip,double km,  int circulo, string dificil, int CP, string tipoActividad, bool aPie) : base(identificador, tittle, descrip, local, tiempo, tip)
        {
            distancia = km;
            circular = circulo;
            dificultad = dificil;

            //AÑADIDO NUEVO(VF):
            //Elementos string CP, string tipoActividad, bool aPie añadidos en parametros
            this.CP = CP;
            this.tipoActividad = tipoActividad;
            this.aPie = aPie;


            numActividad++;

            if (aPie == true)
            {
                if (tipoActividad == "Senderismo")
                {
                    Id = CP + "A" + "01" + numActividad;

                }
                else if (tipoActividad == "Andar")
                {
                    Id = CP + "A" + "02" + numActividad;

                }
                else if (tipoActividad == "Correr")
                {
                    Id = CP + "A" + "03" + numActividad;

                }
                else if (tipoActividad == "Caminata")
                {
                    Id = CP + "A" + "04" + numActividad;
                }
            }
            else
            {
                if (tipoActividad == "Montaña")
                {
                    Id = CP + "A" + "05" + numActividad;

                }
                else if (tipoActividad == "Carretera")
                {
                    Id = CP + "A" + "06" + numActividad;

                }

            }

        }

        public static List<Actividad> CargarActividades(MySqlConnection conexion)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = "SELECT * FROM actividad";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                Actividad act = new Actividad(reader.GetString(1),reader.GetInt32(10));
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


        public void CargarFichaAct(MySqlConnection conexion)
        {
            string consulta = String.Format("SELECT * FROM actividad WHERE id='{0}'", Id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                    Titulo = reader.GetString(1);
                    Descripcion = reader.GetString(2);
                    Localidad = reader.GetString(3);
                    Distancia = reader.GetDouble(4);
                    Circular = reader.GetInt16(5);
                    Dificultad = reader.GetString(6);
                    Duracion = Convert.ToDateTime(reader.GetString(7));
                    Tipo = reader.GetInt32(8);

            }
        }

        public static List<Actividad> FiltroTipo(MySqlConnection conexion, int tipo)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE tipo='{0}'", tipo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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
        //AÑADIDO VM
        public static List<Actividad> FiltroPalabraClave(MySqlConnection conexion, string palabraclave)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE titulo='{0}' OR localidad='{0}'", palabraclave);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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
        //AÑADIDO POR VM
        public static List<Actividad> FiltroLocalidad(MySqlConnection conexion, string localidad)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE localidad='{0}'", localidad);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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

        //AÑADIDO VM
        public static List<Actividad> FiltroKm(MySqlConnection conexion, double distancia)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE distancia='{0}'", distancia);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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

        //AÑADIDO VM

        public static List<Actividad> FiltroTiempo(MySqlConnection conexion, DateTime tiempo)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE tiempo='{0}'", tiempo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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
        //AÑADIDO VM
        public static List<Actividad> FiltroDificultad(MySqlConnection conexion, string dificultad)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE dificultad='{0}'", dificultad);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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
        //AÑADIDO VM
        public static List<Actividad> FiltroCircular(MySqlConnection conexion, int circular)
        {
            List<Actividad> lista = new List<Actividad>();
            string consulta = String.Format("SELECT * FROM actividad WHERE circular='{0}'", circular);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Actividad act = new Actividad();
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

    }
}
