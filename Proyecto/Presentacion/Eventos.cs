using System;

namespace Eventick
{
    public class Eventos : Elemento_a_ofrecer
    {
        private double precio;

        //AÑADIDO (VF):
        static int numEvento = 0;
        private string tipoEvento;
        private string tipoActividadEvento;
        private string Cp;
        private string id;
        private DateTime fecha;

        public double Precio { get { return precio; } set { precio = value; } }


        //AÑADIDO (VF):
        public string TipoEvento { get { return tipoEvento; } set { tipoEvento = value; } }
        public string TipoActividadEvento { get { return tipoActividadEvento; } set { tipoActividadEvento = value; } }
        public string CP { get { return Cp; } set { Cp = value; } }
        public string ID { get { return id; } }

        public Eventos()
        {

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




    }
}
