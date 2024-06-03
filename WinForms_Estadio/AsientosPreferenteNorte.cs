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
    public partial class AsientosPreferenteNorte : Form
    {
        public AsientosPreferenteNorte()
        {
            InitializeComponent();
            RoundButton(btnRegresarSS, 20);
            RoundButton(btncontinuar, 20);

            label4.BackColor = Colores.SkyBlue;
            btnRegresarSS.BackColor = Colores.MintGreen;
            btncontinuar.BackColor = Colores.PeachOrange;
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
        private void AsientosPreferenteNorte_Load(object sender, EventArgs e)
        {

        }

        private void asiento0_Click(object sender, EventArgs e)
        {
            asiento0.BackColor = Color.YellowGreen;
        }

        private void asiento1_Click(object sender, EventArgs e)
        {
            asiento1.BackColor = Color.YellowGreen;
        }

        private void asiento2_Click(object sender, EventArgs e)
        {
            asiento2.BackColor = Color.YellowGreen;
        }

        private void asiento3_Click(object sender, EventArgs e)
        {
            asiento3.BackColor = Color.YellowGreen;

        }

        private void asiento4_Click(object sender, EventArgs e)
        {
            asiento4.BackColor = Color.YellowGreen;

        }

        private void asiento5_Click(object sender, EventArgs e)
        {
            asiento5.BackColor = Color.YellowGreen;

        }

        private void asiento6_Click(object sender, EventArgs e)
        {
            asiento6.BackColor = Color.YellowGreen;

        }

        private void asiento7_Click(object sender, EventArgs e)
        {
            asiento7.BackColor = Color.YellowGreen;

        }

        private void asiento8_Click(object sender, EventArgs e)
        {
            asiento8.BackColor = Color.YellowGreen;

        }

        private void asiento9_Click(object sender, EventArgs e)
        {
            asiento9.BackColor = Color.YellowGreen;

        }

        private void asiento10_Click(object sender, EventArgs e)
        {
            asiento10.BackColor = Color.YellowGreen;

        }

        private void asiento11_Click(object sender, EventArgs e)
        {
            asiento11.BackColor = Color.YellowGreen;

        }

        private void asiento12_Click(object sender, EventArgs e)
        {
            asiento12.BackColor = Color.YellowGreen;

        }

        private void asiento13_Click(object sender, EventArgs e)
        {
            asiento13.BackColor = Color.YellowGreen;

        }

        private void asiento14_Click(object sender, EventArgs e)
        {
            asiento14.BackColor = Color.YellowGreen;

        }

        private void asiento15_Click(object sender, EventArgs e)
        {
            asiento15.BackColor = Color.YellowGreen;

        }

        private void asiento16_Click(object sender, EventArgs e)
        {
            asiento16.BackColor = Color.YellowGreen;

        }

        private void asiento17_Click(object sender, EventArgs e)
        {
            asiento17.BackColor = Color.YellowGreen;

        }

        private void asiento18_Click(object sender, EventArgs e)
        {
            asiento18.BackColor = Color.YellowGreen;

        }

        private void asiento19_Click(object sender, EventArgs e)
        {
            asiento19.BackColor = Color.YellowGreen;

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            PagoDeEntradas pagoDeEntradas = new PagoDeEntradas();
            pagoDeEntradas.Show();
            this.Hide();
        }

        private void btnRegresarSS_Click(object sender, EventArgs e)
        {
            menuZonas menuZonas = new menuZonas();
            menuZonas.Show();
            this.Hide();
        }
    }
}
