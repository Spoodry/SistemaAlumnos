using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaAlumnos
{
    class IntEliminar : Form
    {

        public IntEliminar()
        {
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            ClientSize = new Size(300, 150);
            Text = "Eliminar alumno";
            BackColor = Color.FromArgb(33,33,33);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            CenterToScreen();

            //Inicializar componentes
            TxtMatricula = new TextBox();
            LblMatricula = new Label();
            BtnAceptar = new Button();
            BtnCancelar = new Button();

            //Establecer caracteristicas de componentes
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(160, 25);
            TxtMatricula.Location = new Point(120,20);

            LblMatricula.Name = "LblMatricula";
            LblMatricula.Size = new Size(120, 25);
            LblMatricula.Location = new Point(20, 20);
            LblMatricula.ForeColor = Color.White;
            LblMatricula.Text = "Ingresar matricula: ";

            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(120, 23);
            BtnAceptar.Location = new Point(20, 80);
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.ForeColor = Color.FromArgb(41, 98, 255);
            BtnAceptar.Click += new EventHandler(BtnAceptar_Click);

            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(120, 23);
            BtnCancelar.Location = new Point(150, 80);
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.ForeColor = Color.FromArgb(41, 98, 255);
            BtnCancelar.Click += new EventHandler(BtnCancelar_Click);

            Controls.Add(TxtMatricula);
            Controls.Add(LblMatricula);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            AccesoSQLite.EliminarDatos(int.Parse(TxtMatricula.Text));
            Hide();
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private TextBox TxtMatricula;
        private Label LblMatricula;
        private Button BtnAceptar;
        private Button BtnCancelar;

    }
}
