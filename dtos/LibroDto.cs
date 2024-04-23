using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.dtos
{
    internal class libroDto
    {
        long idLibro;
        string título = "aaaa";
       string subtítulo = "aaaa";
        string autor = "aaaa";
        string iSBN = "aaaa";
        int númeroDeLaEdición = 1111;
       string editorial = "aaaa";
        int stock = 1111;

        public libroDto()
        {
        }

        public libroDto(long idLibro, string título, string subtítulo, string autor, string iSBN, int númeroDeLaEdición, string editorial, int stock)
        {
            this.idLibro = idLibro;
            this.título = título;
            this.subtítulo = subtítulo;
            this.autor = autor;
            this.iSBN = iSBN;
            this.númeroDeLaEdición = númeroDeLaEdición;
            this.editorial = editorial;
            this.stock = stock;
        }

        public long IdLibro { get => idLibro; set => idLibro = value; }
        public string Título { get => título; set => título = value; }
        public string Subtítulo { get => subtítulo; set => subtítulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }
        public int NúmeroDeLaEdición { get => númeroDeLaEdición; set => númeroDeLaEdición = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
