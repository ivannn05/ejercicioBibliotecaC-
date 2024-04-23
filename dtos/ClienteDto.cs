using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejercicio1Global.dtos
{
    internal class ClienteDto
    {
        long idCliente;
         string nombre = "aaaa";
         string apellidos = "aaaa";
        DateTime fechaDeNacimiento = new DateTime(9999,12,31);
         string dNI = "aaaa";
         string correoElectrónico= "aaaa";
        DateTime fechaInicioSuspensión = new DateTime(9999, 12, 31);
        DateTime fechaFinSuspensión = new DateTime(9999, 12, 31);

        public ClienteDto()
        {
        }

        public ClienteDto(long idCliente, string nombre, string apellidos, DateTime fechaDeNacimiento, string dNI, string correoElectrónico, DateTime fechaInicioSuspensión, DateTime fechaFinSuspensión)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dNI = dNI;
            this.correoElectrónico = correoElectrónico;
            this.fechaInicioSuspensión = fechaInicioSuspensión;
            this.fechaFinSuspensión = fechaFinSuspensión;
        }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string DNI { get => dNI; set => dNI = value; }
        public string CorreoElectrónico { get => correoElectrónico; set => correoElectrónico = value; }
        public DateTime FechaInicioSuspensión { get => fechaInicioSuspensión; set => fechaInicioSuspensión = value; }
        public DateTime FechaFinSuspensión { get => fechaFinSuspensión; set => fechaFinSuspensión = value; }
    }
}
