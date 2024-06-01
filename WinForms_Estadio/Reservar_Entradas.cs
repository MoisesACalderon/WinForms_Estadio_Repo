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
    public partial class Reservar_Entradas : Form
    {
        public Reservar_Entradas()
        {
            InitializeComponent();

            RoundButton(btnelsalvadorvsargentina, 20);
            RoundButton(btnregresar, 20);

            btnelsalvadorvsargentina.BackColor = Colores.SkyBlue;
            btnregresar.BackColor = Colores.MintGreen;

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
