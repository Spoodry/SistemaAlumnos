using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Alumno
    {

        private String nombre;
        private String apellidoP;
        private String apellidoM;
        private String fechNacimiento;
        private String domicilio;
        private int matricula;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string FechNacimiento { get => fechNacimiento; set => fechNacimiento = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Matricula { get => matricula; set => matricula = value; }

        public Alumno(String nombre, String apellidoP, String apellidoM, String fechNacimiento, String domicilio, int matricula)
        {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.fechNacimiento = fechNacimiento;
            this.domicilio = domicilio;
            this.matricula = matricula;
        }

    }
}
