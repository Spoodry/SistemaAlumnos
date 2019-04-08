using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaAlumnos
{
    class AccesoSQLite
    {

        public static void GetDatos(DataGridView DataGrid)
        {

            using(IDbConnection cnn = new SQLiteConnection("Data Source=.\\Escuela.db; Version=3;"))
            {
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter
                    ("select AlumnoID, Nombre, ApellidoP as 'Apellido Paterno', ApellidoM as 'Apellido Materno', FechNacimiento as" +
                    "'Fecha nacimiento', Domicilio, Matricula from Alumnos", (SQLiteConnection) cnn);
                DataTable dataTable = new DataTable();

                sQLiteDataAdapter.Fill(dataTable);

                DataGrid.DataSource = dataTable;

            }

        }

        public static void SetDatos(Alumno alumno)
        {

            using (IDbConnection cnn = new SQLiteConnection("Data Source=.\\Escuela.db; Version=3;"))
            {
                cnn.Open();
                SQLiteCommand insertSQL = new SQLiteCommand("insert into Alumnos(Nombre, ApellidoP, " +
                    "ApellidoM, FechNacimiento, Domicilio, Matricula) values(?,?,?,?,?,?)", (SQLiteConnection)cnn);
                insertSQL.Parameters.Add(new SQLiteParameter("Nombre", alumno.Nombre));
                insertSQL.Parameters.Add(new SQLiteParameter("ApellidoP", alumno.ApellidoP));
                insertSQL.Parameters.Add(new SQLiteParameter("ApellidoM", alumno.ApellidoM));
                insertSQL.Parameters.Add(new SQLiteParameter("FechNacimiento", alumno.FechNacimiento));
                insertSQL.Parameters.Add(new SQLiteParameter("Domicilio", alumno.Domicilio));
                insertSQL.Parameters.Add(new SQLiteParameter("Matricula", alumno.Matricula));

                try
                {
                    insertSQL.ExecuteNonQuery();
                } catch(Exception e)
                {
                    throw new Exception(e.Message);
                }

            }

        }

        public static void EliminarDatos(int matricula)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source=.\\Escuela.db; Version=3;"))
            {
                cnn.Open();
                SQLiteCommand deleteSQL = new SQLiteCommand("delete from Alumnos where Matricula = ?", 
                    (SQLiteConnection)cnn);
                deleteSQL.Parameters.Add(new SQLiteParameter("Matricula", matricula));

                try
                {
                    deleteSQL.ExecuteNonQuery();
                } catch(Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public static void ActualizarDatos(Alumno alumno)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source=.\\Escuela.db; Version=3;"))
            {
                cnn.Open();
                SQLiteCommand updateSQL = new SQLiteCommand("update Alumnos set Nombre = ?, ApellidoP = ?, ApellidoM = ?, " +
                    "FechNacimiento = ?, Domicilio = ? where Matricula = ?", (SQLiteConnection)cnn);
                updateSQL.Parameters.Add(new SQLiteParameter("Nombre", alumno.Nombre));
                updateSQL.Parameters.Add(new SQLiteParameter("ApellidoP", alumno.ApellidoP));
                updateSQL.Parameters.Add(new SQLiteParameter("ApellidoM", alumno.ApellidoM));
                updateSQL.Parameters.Add(new SQLiteParameter("FechNacimiento", alumno.FechNacimiento));
                updateSQL.Parameters.Add(new SQLiteParameter("Domicilio", alumno.Domicilio));
                updateSQL.Parameters.Add(new SQLiteParameter("Matricula", alumno.Matricula));

                try
                {
                    updateSQL.ExecuteNonQuery();
                } catch(Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

    }
}
