using ejercicio1Global.controladores;
using ejercicio1Global.dtos;
using ejercicio1Global.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
       Util utilidades= new Util();
        Program usos;
        public void darAltaBiblioteca(List<BibliotecaDto> listaBiblioteca)
        {
             BibliotecaDto biblio = new BibliotecaDto();
            biblio.IdBlibio = utilidades.incrementoIdBiblioteca(listaBiblioteca,biblio);
            Program.idBiblio = utilidades.incrementoIdBiblioteca(listaBiblioteca, biblio); 
            Console.WriteLine("Indique el nombre de la biblioteca");
            biblio.Nombre = Console.ReadLine();
            Console.WriteLine("Indique la direccion de la biblioteca");
            biblio.Dirección = Console.ReadLine();
            listaBiblioteca.Add(biblio);
        }

        public void darAltaClientes(List<ClienteDto> listaCliente)
        {
            ClienteDto cliente = new ClienteDto();
            cliente.IdCliente = utilidades.incrementoIdCliente(listaCliente, cliente);
            Console.WriteLine("Indique el nombre del cliente ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Indique el apellidos del cliente ");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Indique la fecha de nacimiento del cliente ");
            cliente.FechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Indique el DNI del cliente ");
            cliente.DNI = Console.ReadLine();
            Console.WriteLine("Indique el correo del cliente ");
            cliente.CorreoElectrónico = Console.ReadLine();
            Console.WriteLine("Indique la fecha de inicio del cliente ");
            cliente.FechaInicioSuspensión = Convert.ToDateTime(Console.ReadLine());

            cliente.FechaFinSuspensión.AddDays(7);

            listaCliente.Add(cliente);

        }
        /*Nombre
Apellidos
Fecha de nacimiento
DNI
Correo electrónico
Fecha inicio suspensión
Fecha fin suspensión*/

        public void darAltaLibros(List<libroDto> listaLibros)
        {
           libroDto libro = new libroDto();
            libro.IdLibro = utilidades.incrementoIdLibro(listaLibros, libro);
            
            Console.WriteLine("Indique el titulo del libro ");
            libro.Título = Console.ReadLine();
            Console.WriteLine("Indique el Subtítulo del libro ");
            libro.Subtítulo = Console.ReadLine();
            Console.WriteLine("Indique el ISBN del libro ");
            libro.ISBN = Console.ReadLine();
            Console.WriteLine("Indique el Número de la edición del libro ");
            libro.NúmeroDeLaEdición = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la Editorial del libro ");
            libro.Editorial = Console.ReadLine();
            Console.WriteLine("Indique el Stock del libro ");
            libro.Stock = Convert.ToInt32(Console.ReadLine());
            listaLibros.Add(libro);

        }
        /*Título
Subtítulo
Autor
ISBN
Número de la edición
Editorial
Stock*/

        public void darAltaPrestamos(List<PrestamoDto> listaPrestamos)
        {
            PrestamoDto prestamo = new PrestamoDto();
            prestamo.IdPrestamo = utilidades.incrementoIdPrestamo(listaPrestamos, prestamo);
           Console.WriteLine("Indique el titulo del libro ");
           // prestamo.IdentificadorDelLibro

        }
        /*Identificador del préstamo
Identificador del cliente
Identificador del libro
Fecha de préstamo
Fecha de entrega
Estado del préstamo*/
    }
}
