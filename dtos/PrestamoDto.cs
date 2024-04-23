using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Global.dtos
{
    internal class PrestamoDto
    {
       long idPrestamo;
        
      int identificadorDelCliente;
      int  identificadorDelLibro;
        DateTime fechaDePréstamo = new DateTime(9999, 12, 31);
       DateTime fechaDeEntrega = new DateTime(9999, 12, 31);
        DateTime estadoDelPréstamo = new DateTime(9999, 12, 31);

        public PrestamoDto()
        {
        }

        public PrestamoDto(long idPrestamo,  int identificadorDelCliente, int identificadorDelLibro, DateTime fechaDePréstamo, DateTime fechaDeEntrega, DateTime estadoDelPréstamo)
        {
            this.idPrestamo = idPrestamo;
        
            this.identificadorDelCliente = identificadorDelCliente;
            this.identificadorDelLibro = identificadorDelLibro;
            this.fechaDePréstamo = fechaDePréstamo;
            this.fechaDeEntrega = fechaDeEntrega;
            this.estadoDelPréstamo = estadoDelPréstamo;
        }

        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
       
        public int IdentificadorDelCliente { get => identificadorDelCliente; set => identificadorDelCliente = value; }
        public int IdentificadorDelLibro { get => identificadorDelLibro; set => identificadorDelLibro = value; }
        public DateTime FechaDePréstamo { get => fechaDePréstamo; set => fechaDePréstamo = value; }
        public DateTime FechaDeEntrega { get => fechaDeEntrega; set => fechaDeEntrega = value; }
        public DateTime EstadoDelPréstamo { get => estadoDelPréstamo; set => estadoDelPréstamo = value; }
    }
}
