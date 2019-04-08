using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaAlumnos
{
    class IntActualizar : Form
    {

        private Alumno alumno;

        public Alumno Alumno { get => alumno; }

        private TextBox textBoxNombre;
        private TextBox textBoxApellidoP;
        private TextBox textBoxApellidoM;
        private TextBox textBoxFechN;
        private TextBox textBoxDom;
        private TextBox textBoxMatri;
        private Button botonCancelar;

        public IntActualizar()
        {
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            //Caracteristicas de la ventana
            ClientSize = new Size(500, 250);
            Name = "IntActualizar";
            Text = "Actualizar alumno";
            BackColor = Color.FromArgb(33, 33, 33);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            CenterToScreen();

            //Inicializar Componentes
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            Label labelNombre = new Label();
            Label labelApellidoP = new Label();
            Label labelApellidoM = new Label();
            Label labelFechN = new Label();
            Label labelDom = new Label();
            Label labelMatri = new Label();
            textBoxNombre = new TextBox();
            textBoxApellidoP = new TextBox();
            textBoxApellidoM = new TextBox();
            textBoxFechN = new TextBox();
            textBoxDom = new TextBox();
            textBoxMatri = new TextBox();
            Button botonAceptar = new Button();
            botonCancelar = new Button();

            //Establecer caracteristicas de componentes
            tableLayout.Name = "tableLayout";
            tableLayout.Width = Width;
            tableLayout.Height = 200;
            tableLayout.ColumnCount = 2;
            tableLayout.RowCount = 6;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            labelNombre.Name = "labelNombre";
            labelNombre.Text = "Nombre:";
            labelNombre.ForeColor = Color.White;
            labelNombre.Width = 200;

            labelApellidoP.Name = "labelApellidoP";
            labelApellidoP.Text = "Apellido paterno:";
            labelApellidoP.ForeColor = Color.White;
            labelApellidoP.Width = 200;

            labelApellidoM.Name = "labelApellidoM";
            labelApellidoM.Text = "Apellido materno:";
            labelApellidoM.ForeColor = Color.White;
            labelApellidoM.Width = 200;

            labelFechN.Name = "labelFechN";
            labelFechN.Text = "Fecha de nacimiento:";
            labelFechN.ForeColor = Color.White;
            labelFechN.Width = 200;

            labelDom.Name = "labelDom";
            labelDom.Text = "Domicilio:";
            labelDom.ForeColor = Color.White;
            labelDom.Width = 200;

            labelMatri.Name = "labelMatri";
            labelMatri.Text = "Matricula a actualizar:";
            labelMatri.ForeColor = Color.White;
            labelMatri.Width = 200;

            textBoxNombre.Name = "txtBoxNombre";
            textBoxNombre.Size = new Size(330, 23);
            textBoxNombre.TabIndex = 0;

            textBoxApellidoP.Name = "txtBoxApellidoP";
            textBoxApellidoP.Size = new Size(330, 23);
            textBoxApellidoP.TabIndex = 1;

            textBoxApellidoM.Name = "txtBoxApellidoM";
            textBoxApellidoM.Size = new Size(330, 23);
            textBoxApellidoM.TabIndex = 2;

            textBoxFechN.Name = "txtBoxFechN";
            textBoxFechN.Size = new Size(330, 23);
            textBoxFechN.TabIndex = 3;

            textBoxDom.Name = "txtBoxDom";
            textBoxDom.Size = new Size(330, 23);
            textBoxDom.TabIndex = 4;

            textBoxMatri.Name = "txtBoxMatri";
            textBoxMatri.Size = new Size(330, 23);
            textBoxMatri.TabIndex = 5;

            botonAceptar.Name = "btnAceptar";
            botonAceptar.Size = new Size(120, 23);
            botonAceptar.Text = "Aceptar";
            botonAceptar.TabIndex = 6;
            botonAceptar.Location = new Point(120, 200);
            botonAceptar.UseVisualStyleBackColor = true;
            botonAceptar.FlatStyle = FlatStyle.Flat;
            botonAceptar.ForeColor = Color.FromArgb(41, 98, 255);
            botonAceptar.Click += new EventHandler(BotonAceptar_Click);

            botonCancelar.Name = "btnCancelar";
            botonCancelar.Size = new Size(120, 23);
            botonCancelar.Text = "Cancelar";
            botonCancelar.TabIndex = 7;
            botonCancelar.Location = new Point(270, 200);
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.FlatStyle = FlatStyle.Flat;
            botonCancelar.ForeColor = Color.FromArgb(41, 98, 255);
            botonCancelar.Click += new EventHandler(BotonCancelar_Click);

            //Añadir componentes
            tableLayout.Controls.Add(labelMatri, 0, 0);
            tableLayout.Controls.Add(labelNombre, 0, 1);
            tableLayout.Controls.Add(labelApellidoP, 0, 2);
            tableLayout.Controls.Add(labelApellidoM, 0, 3);
            tableLayout.Controls.Add(labelFechN, 0, 4);
            tableLayout.Controls.Add(labelDom, 0, 5);
            tableLayout.Controls.Add(textBoxMatri, 1, 0);
            tableLayout.Controls.Add(textBoxNombre, 1, 1);
            tableLayout.Controls.Add(textBoxApellidoP, 1, 2);
            tableLayout.Controls.Add(textBoxApellidoM, 1, 3);
            tableLayout.Controls.Add(textBoxFechN, 1, 4);
            tableLayout.Controls.Add(textBoxDom, 1, 5);
            Controls.Add(tableLayout);
            Controls.Add(botonAceptar);
            Controls.Add(botonCancelar);
        }

        private void BotonAceptar_Click(Object sender, EventArgs e)
        {
            alumno = new Alumno(textBoxNombre.Text, textBoxApellidoP.Text, textBoxApellidoM.Text, textBoxFechN.Text, textBoxDom.Text,
                int.Parse(textBoxMatri.Text));
            AccesoSQLite.ActualizarDatos(alumno);
            Hide();
            Close();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

    }
}
