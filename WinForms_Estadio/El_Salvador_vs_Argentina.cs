using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            RoundButton(btnverprecios, 20);
            RoundButton(btncomprarentradas, 20);
            RoundButton(btnverificarentradas, 20);
            RoundButton(btnregresar, 20);
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

        private void El_Salvador_vs_Argentina_Load(object sender, EventArgs e)
        {

        }
        private void RoundButton(Button button, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radio * 2, radio * 2, 180, 90);
            path.AddArc(rect.Width - radio * 2, rect.Y, radio * 2, radio * 2, 270, 90);
            path.AddArc(rect.Width - radio * 2, rect.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddArc(rect.X, rect.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseAllFigures();

            button.Region = new Region(path);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
    }
}
