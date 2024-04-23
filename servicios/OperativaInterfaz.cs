using ejercicio1Global.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaBiblioteca(List<BibliotecaDto> listaBiblioteca);
        public void darAltaClientes(List<ClienteDto> listaCliente);
        public void darAltaLibros(List<libroDto> listaLibros);
        public void darAltaPrestamos(List<PrestamoDto> listaPrestamos);
    }
}
