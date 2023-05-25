using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria
{
    internal class Mascota
    {
        public string nombre;
        public string edad;
        public string raza;
        public string dueño; // Indexa de un comboBox de tipo Dueño

        public Mascota(string nombre, string edad, string raza, string dueño)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.raza = raza;
            this.dueño = dueño;
        }

    }
}
