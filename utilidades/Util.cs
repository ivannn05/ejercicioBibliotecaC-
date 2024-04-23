using ejercicio1Global.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.utilidades
{
    internal class Util
    {
        public long incrementoIdBiblioteca(List<BibliotecaDto> listaBiblio, BibliotecaDto biblioteca)
        {
            long id=biblioteca.IdBlibio;
            if (id == 0)
            {
                id = 1;
            }
            else
            {
                long nuevoid;
                int posicion=listaBiblio.Count-1;
                nuevoid = listaBiblio[posicion].IdBlibio + 1;
                    id=nuevoid;
                
            }

            return id;
        }

        public long incrementoIdCliente(List<ClienteDto> listaCliente, ClienteDto cliente)
        {
            long id = cliente.IdCliente;
            if (id == 0)
            {
                id = 1;
            }
            else
            {
                long nuevoid;
                int posicion = listaCliente.Count - 1;
                nuevoid = listaCliente[posicion].IdCliente + 1;
                id = nuevoid;

            }

            return id;
        }
        public long incrementoIdLibro(List<libroDto> listalibro, libroDto libro)
        {
            long id = libro.IdLibro;
            if (id == 0)
            {
                id = 1;
            }
            else
            {
                long nuevoid;
                int posicion = listalibro.Count - 1;
                nuevoid = listalibro[posicion].IdLibro + 1;
                id = nuevoid;

            }

            return id;
        }
        public long incrementoIdPrestamo(List<PrestamoDto> listaPrestamo, PrestamoDto prestamo)
        {
            long id = prestamo.IdPrestamo;
            if (id == 0)
            {
                id = 1;
            }
            else
            {
                long nuevoid;
                int posicion = listaPrestamo.Count - 1;
                nuevoid = listaPrestamo[posicion].IdPrestamo + 1;
                id = nuevoid;

            }

            return id;
        }
    }
}
