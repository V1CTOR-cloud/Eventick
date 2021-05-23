using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventick
{
   public static class UserLoginCache
    {
        public static string Nickname { get; set; }
        public static string Nombre { get; set; }
        public static string Apellidos { get; set; }
        public static string Email { get; set; }
        public static int Edad{ get; set; }
        public static int CP { get; set; }
        public static string Localidad { get; set; }

    }
}
