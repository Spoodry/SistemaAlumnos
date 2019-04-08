using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaAlumnos
{
    class Interfaz : Form
    {

        private DataGridView DataGridAlumnos;

        public Interfaz()
        {
            InicializarComponentes();
            AccesoSQLite.GetDatos(DataGridAlumnos);
        }

        private void InicializarComponentes()
        {
            //Caracteristicas de la ventana
            ClientSize = new Size(900, 450);
            Name = "InterfazAlumnos";
            Text = "Alumnos";
            BackColor = Color.FromArgb(33,33,33);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            CenterToScreen();

            //Instanciar componentes
            Button BotonAgregar = new Button();
            Button BotonEliminar = new Button();
            Button BotonActualizar = new Button();
            Button BotonRefrescar = new Button();
            DataGridAlumnos = new DataGridView();
            TableLayoutPanel TableSuperior = new TableLayoutPanel();

            //Establecer caracteristicas de los componentes
            TableSuperior.Name = "TableSuperior";
            TableSuperior.Width = Width;
            TableSuperior.Height = 50;
            TableSuperior.Location = new Point(44, 30);
            TableSuperior.ColumnCount = 4;
            TableSuperior.RowCount = 1;
            TableSuperior.BackColor = Color.Transparent;
            TableSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Text = "Agregar";
            //BotonAgregar.Location = new Point(50, alturaBotones);
            BotonAgregar.Size = new Size(120, 23);
            BotonAgregar.TabIndex = 0;
            BotonAgregar.FlatStyle = FlatStyle.Flat;
            BotonAgregar.ForeColor = Color.FromArgb(41, 98, 255);
            BotonAgregar.Click += new EventHandler(BotonAgregar_Click);

            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Text = "Eliminar";
            //BotonEliminar.Location = new Point(200, alturaBotones);
            BotonEliminar.Size = new Size(120, 23);
            BotonEliminar.TabIndex = 1;
            BotonEliminar.FlatStyle = FlatStyle.Flat;
            BotonEliminar.ForeColor = Color.FromArgb(41, 98, 255);
            BotonEliminar.Click += new EventHandler(BotonEliminar_Click);

            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Text = "Actualizar";
            ///BotonActualizar.Location = new Point(400, alturaBotones);
            BotonActualizar.Size = new Size(120, 23);
            BotonActualizar.TabIndex = 2;
            BotonActualizar.FlatStyle = FlatStyle.Flat;
            BotonActualizar.ForeColor = Color.FromArgb(41, 98, 255);
            BotonActualizar.Click += new EventHandler(BotonActualizar_Click);

            BotonRefrescar.Name = "BotonRefrescar";
            BotonRefrescar.Text = "Refrescar";
            BotonRefrescar.Size = new Size(120, 23);
            BotonRefrescar.TabIndex = 3;
            BotonRefrescar.FlatStyle = FlatStyle.Flat;
            BotonRefrescar.ForeColor = Color.FromArgb(41, 98, 255);
            BotonRefrescar.Click += new EventHandler(BotonRefrescar_Click);

            DataGridAlumnos.Name = "DataGridAlumnos";
            DataGridAlumnos.Location = new Point(50, 90);
            DataGridAlumnos.Size = new Size(800, 300);
            DataGridAlumnos.ReadOnly = true;
            DataGridAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridAlumnos.RowHeadersVisible = false;

            //Agregar los componentes al form
            TableSuperior.Controls.Add(BotonAgregar, 0, 0);
            TableSuperior.Controls.Add(BotonEliminar, 1, 0);
            TableSuperior.Controls.Add(BotonActualizar, 2, 0);
            TableSuperior.Controls.Add(BotonRefrescar, 3, 0);
            Controls.Add(TableSuperior);
            Controls.Add(DataGridAlumnos);

        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            IntAgregar formulario = new IntAgregar();
            formulario.FormClosing += new FormClosingEventHandler(Interfaz_FormClosing);
            formulario.Show();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            Hide();
            IntEliminar formulario = new IntEliminar();
            formulario.FormClosing += new FormClosingEventHandler(Interfaz_FormClosing);
            formulario.Show();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            Hide();
            IntActualizar formulario = new IntActualizar();
            formulario.FormClosing += new FormClosingEventHandler(Interfaz_FormClosing);
            formulario.Show();
        }

        private void BotonRefrescar_Click(object sender, EventArgs e)
        {
            AccesoSQLite.GetDatos(DataGridAlumnos);
        }

        private void Interfaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Show();
        }

    }
}
