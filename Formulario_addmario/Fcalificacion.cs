using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formulario_addmario
{
    public partial class Fcalificacion : Form
    {
        public Fcalificacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            var calif = new calificacion
            {
                nombre = dbnombremateria.Text,
                parcial1 = int.Parse(dbparcial1.Text),
                parcial2 = int.Parse(dbparcial2.Text),
                parcial3 = int.Parse(dbparcial3.Text),
                alumno = dbalumno.Text

            };
            lista.InsertOne(calif);
        }
    }
}
