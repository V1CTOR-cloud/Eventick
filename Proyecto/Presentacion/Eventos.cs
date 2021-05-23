using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Eventick
{
    public class Eventos : Elemento_a_ofrecer
    {
        private double precio;

        //AÑADIDO (VF):
        static int numEvento = 0;
        private string tipoEvento;
        private string tipoActividadEvento;
        private int Cp;
        private string id;
        private DateTime fecha;

        public double Precio { get { return precio; } set { precio = value; } }


        //AÑADIDO (VF):
        public string TipoEvento { get { return tipoEvento; } set { tipoEvento = value; } }
        public string TipoActividadEvento { get { return tipoActividadEvento; } set { tipoActividadEvento = value; } }
        public int CP { get { return Cp; } set { Cp = value; } }
        public string ID { get { return id; } }

        public Eventos()
        {

        }

        public Eventos(string tae, int codigo)
        {
            CP = codigo;
            numEvento++;

            if (tae == "Concierto")
            {
                this.id = CP + "E" + "01" + numEvento++;

            }
            else if (tae == "Escape Room")
            {
                this.id = CP + "E" + "02" + numEvento++;

            }
            else if (tae == "Bar con musica en directo")
            {
                this.id = CP + "E" + "03" + numEvento++;

            }
            if (tipoActividadEvento == "Teatro - Danza")
            {
                this.id = CP + "E" + "04" + numEvento++;

            }
            else if (tipoActividadEvento == "Museo - Exposiciones")
            {
                this.id = CP + "E" + "05" + numEvento++;

            }
            else if (tipoActividadEvento == "Visitas guiadas")
            {
                this.id = CP + "E" + "06" + numEvento++;

            }
            if (tipoActividadEvento == "Baloncesto")
            {
                this.id = CP + "E" + "07" + numEvento++;

            }
            else if (tipoActividadEvento == "Tenis")
            {
                this.id = CP + "E" + "08" + numEvento++;

            }
            else if (tipoActividadEvento == "Futbol")
            {
                this.id = CP + "E" + "09" + numEvento++;

            }
            else if (tipoActividadEvento == "Otros deportes")
            {
                this.id = CP + "E" + "010" + numEvento++;

            }


        }

        public Eventos(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip, double dinero, string tipoActividadEvento) : base(identificador, tittle, descrip, local, tiempo, tip)
        {
            precio = dinero;

            //AÑADIDO (VF):
          
            this.CP = CP;
            this.tipoActividadEvento = tipoActividadEvento;

            numEvento++;

            if (tipoEvento == "Ocio")
            {
                if (tipoActividadEvento == "Concierto")
                {
                    this.id = CP + "E" + "01" + numEvento++;

                }
                else if (tipoActividadEvento == "Escape Room")
                {
                    this.id = CP + "E" + "02" + numEvento++;

                }
                else if (tipoActividadEvento == "Bar con musica en directo")
                {
                    this.id = CP + "E" + "03" + numEvento++;

                }

            }
            else if (tipoEvento == "Cultural")
            {
                if (tipoActividadEvento == "Teatro - Danza")
                {
                    this.id = CP + "E" + "04" + numEvento++;

                }
                else if (tipoActividadEvento == "Museo - Exposiciones")
                {
                    this.id = CP + "E" + "05" + numEvento++;

                }
                else if (tipoActividadEvento == "Visitas guiadas")
                {
                    this.id = CP + "E" + "06" + numEvento++;

                }

            }
            else if (tipoEvento == "Desportivo")
            {
                if (tipoActividadEvento == "Baloncesto")
                {
                    this.id = CP + "E" + "07" + numEvento++;

                }
                else if (tipoActividadEvento == "Tenis")
                {
                    this.id = CP + "E" + "08" + numEvento++;

                }
                else if (tipoActividadEvento == "Futbol")
                {
                    this.id = CP + "E" + "09" + numEvento++;

                }
                else if (tipoActividadEvento == "Otros deportes")
                {
                    this.id = CP + "E" + "010" + numEvento++;

                }
            }





        }

        public static List<Eventos> CargarEventos(MySqlConnection conexion)
        {
            List<Eventos> lista = new List<Eventos>();
            string consulta = "SELECT * FROM evento";

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
                act.precio = reader.GetDouble(7);
                act.CP = reader.GetInt32(9);
                lista.Add(act);
            }
            reader.Close();


            return lista;
        }

        public void VerFichaEvento(MySqlConnection conexion)
        {
            string consulta = String.Format("SELECT * FROM evento WHERE id='{0}'", Id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                Titulo = reader.GetString(1);
                Descripcion = reader.GetString(2);
                Localidad = reader.GetString(3);
                Duracion = DateTime.Parse(reader.GetString(4));
                Tipo = reader.GetInt16(5);
                TipoActividadEvento = reader.GetString(6);
                Precio =reader.GetDouble(7);
                CP = reader.GetInt32(9);

            }

        }

    }
}
