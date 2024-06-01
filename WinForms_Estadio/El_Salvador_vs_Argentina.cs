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
    public partial class El_Salvador_vs_Argentina : Form
    {
        public El_Salvador_vs_Argentina()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Reservar_Entradas ventana2 = new Reservar_Entradas();
            ventana2.Show();

            this.Hide();
        }

        private void btnverprecios_Click(object sender, EventArgs e)
        {
            Ver_Precios ventana2 = new Ver_Precios();
            ventana2.Show();

            this.Hide();
        }
    }
}
