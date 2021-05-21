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
        private string Cp;


        public double Distancia { get { return distancia; } set { distancia = value; } }
        public int Circular { get {return circular; } set {circular = value; } }
        public string Dificultad { get{return dificultad; } set {dificultad = value; } }

        //AÑADIDO(VF):
        public int NumActividad { get { return numActividad; } }
        public bool APie { get { return aPie; } set { aPie = value; } }
        public string TipoActividad { get { return tipoActividad; } set { tipoActividad = value; } }
        public string CP { get { return CP; } set { CP = value; } }

        public Actividad()
        {

        }

        public Actividad(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip,double km,  int circulo, string dificil, string CP, string tipoActividad, bool aPie) : base(identificador, tittle, descrip, local, tiempo, tip)
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


        public void CargarFichaAct(MySqlConnection conexion)
        {
            string consulta = String.Format("SELECT * FROM actividad WHERE id='{0}'", Id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
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

                
            }


        }

            

    }
}
