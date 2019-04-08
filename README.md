# SistemaAlumnos
Prueba de conexión a SQLite

```[C#]
    class Alumno
    {

        private String nombre;
        private String apellidoP;
        private String apellidoM;
        private String fechNacimiento;
        private String domicilio;
        private int matricula;

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
```

> La vida es muy corta para aprender Alemán. -Tad Marburg