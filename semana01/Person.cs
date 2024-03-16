using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana01
{
    public class Person
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad {  get; set; }

        public string GetNombreCompletos()
        { return Nombres + " " + Apellidos; }

        public bool EsMayorEdad()
        { return Edad == 0; }

    }
}
