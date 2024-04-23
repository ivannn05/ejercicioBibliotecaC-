using ejercicio1Global.dtos;
using ejercicio1Global.servicios;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ejercicio1Global.controladores
{
    
    class Program
    {
        static List<BibliotecaDto> listaBiblioteca = new List<BibliotecaDto>();
        static List<ClienteDto> listaCliente = new List<ClienteDto>();
        static List<libroDto> listalibro = new List<libroDto>();
        static List<PrestamoDto> listaPrestamo = new List<PrestamoDto>();

        static public long idBiblio;
        static public long idCliente;
        static public long idBLibro;
        static public long idPrestamo;
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();
          
           

            int opcion;
            bool cerrarMenu=false;


            while(!cerrarMenu)
            {
                opcion = mi.mostrarMenuBiblioteca();
                switch (opcion)
                {
                    case 0:
                        cerrarMenu=true;
                        break;
                        case 1:
                        op.darAltaBiblioteca(listaBiblioteca);
                        break;
                        case 2:
                        op.EntrarEnBiblioteca();
                        break;
                   
                            
                }
                

            }
            op


        }
    }
}
