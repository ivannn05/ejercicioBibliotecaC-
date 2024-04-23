using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejercicio1Global.dtos
{
    internal class BibliotecaDto
    {
        long idBlibio;
        string nombre = "aaaa";

        string dirección = "aaaa";

        public BibliotecaDto()
        {
        }

        public BibliotecaDto(long idBlibio, string nombre, string dirección)
        {
            this.IdBlibio = idBlibio;
            Nombre = nombre;
            Dirección = dirección;
        }

        public long IdBlibio { get => idBlibio; set => idBlibio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dirección { get => dirección; set => dirección = value; }
    }
}
