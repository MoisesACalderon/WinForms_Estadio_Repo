using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Estadio
{
    public partial class Reservar_Entradas : Form
    {
        public Reservar_Entradas()
        {
            InitializeComponent();
        }

        private void Reservar_Entradas_Load(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 ventana2 = new Form1();
            ventana2.Show();

            this.Hide();
        }

        private void btnelsalvadorvsargentina_Click(object sender, EventArgs e)
        {
            El_Salvador_vs_Argentina ventana = new El_Salvador_vs_Argentina();
            ventana.Show();

            this.Hide();
        }
    }
}
