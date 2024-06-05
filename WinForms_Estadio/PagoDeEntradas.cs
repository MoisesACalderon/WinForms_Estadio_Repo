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
    public partial class PagoDeEntradas : Form
    {
        public PagoDeEntradas()
        {
            InitializeComponent();
            RoundButton(btnRegresarSS, 20);
            RoundButton(btncontinuar, 20);
            RoundLabel(label1, 2);
            RoundLabel(label6, 2);
            RoundLabel(label7, 2);
            RoundLabel(label8, 2);
            RoundTextBox(textBox1, 2);
            RoundTextBox(textBox2, 2);
            RoundTextBox(textBox3, 2);
            RoundTextBox(textBox4, 2);
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarSS_Click(object sender, EventArgs e)
        {
            menuZonas menuZonas = new menuZonas();
            menuZonas.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            ConfirmacionDePago confirmacionDePago = new ConfirmacionDePago();
            confirmacionDePago.Show();
            this.Hide();
        }

        private void PagoDeEntradas_Load(object sender, EventArgs e)
        {

        }
        private void RoundTextBox(TextBox textBox, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = textBox.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radio * 2, radio * 2, 180, 90);
            path.AddArc(rect.Width - radio * 2, rect.Y, radio * 2, radio * 2, 270, 90);
            path.AddArc(rect.Width - radio * 2, rect.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddArc(rect.X, rect.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseAllFigures();
            textBox.Region = new Region(path);
            textBox.BorderStyle = BorderStyle.None;
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
    }
}
