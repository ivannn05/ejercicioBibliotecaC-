using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuBiblioteca()
        {
            int opc;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Crear biblioteca");
            Console.WriteLine("2.Entrar en una biblioteca");

            opc =Convert.ToInt32(Console.ReadLine());

            return opc;
        }

        public int mostrarMenuClientes()
        {

            int opc;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Crear cliente");
            Console.WriteLine("2.Entrar en un cliente");

            opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }

        public int mostrarMenuLibros()
        {

            int opc;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Crear libro");
            Console.WriteLine("2.Entrar en un libro");

            opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }

        public int mostrarMenuPrestamos()
        {

            int opc;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Crear prestamo");
            Console.WriteLine("2.Entrar en un prestamo");

            opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
