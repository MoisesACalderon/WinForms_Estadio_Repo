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
    public partial class ConfirmacionDePago : Form
    {
        public ConfirmacionDePago()
        {
            InitializeComponent();
            RoundButton(btnRegresarSS, 20);
            RoundButton(btncontinuar, 20);
            RoundButton(btnseguircom, 20);
            btnRegresarSS.BackColor = Colores.MintGreen;
            btncontinuar.BackColor = Colores.PeachOrange;
            btnseguircom.BackColor = Colores.SkyBlue;

            RoundLabel(label1, 2);
            RoundLabel(label6, 2);
            RoundLabel(label7, 2);
            RoundLabel(label8, 2);
            RoundLabel(label9, 2);
            RoundLabel(label10, 2);
            RoundLabel(label11, 2);
            RoundLabel(label12, 2);
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

        private void btnRegresarSS_Click(object sender, EventArgs e)
        {
            MenuPrincipal form1 = new MenuPrincipal();
            form1.Show();
            this.Hide();
        }

        private void btnseguircom_Click(object sender, EventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            VerificarEntradas verificarEntradas = new VerificarEntradas();
            verificarEntradas.Show();
            this.Hide();
        }

        private void ConfirmacionDePago_Load(object sender, EventArgs e)
        {

        }
        private void RoundLabel(Label label, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = label.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radio * 2, radio * 2, 180, 90);
            path.AddArc(rect.Width - radio * 2, rect.Y, radio * 2, radio * 2, 270, 90);
            path.AddArc(rect.Width - radio * 2, rect.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddArc(rect.X, rect.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseAllFigures();
            label.Region = new Region(path);
            label.BorderStyle = BorderStyle.None;
            label.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            El_Salvador_vs_Argentina el_Salvador_Vs_Argentina = new El_Salvador_vs_Argentina();
            el_Salvador_Vs_Argentina.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
