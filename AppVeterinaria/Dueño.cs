using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria
{
    internal class Dueño
    {
        public string nombre;
        public string direccion;
        public string telefono;
        
        public Dueño(string nombre, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
}
