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
using static System.Windows.Forms.DataFormats;

namespace WinForms_Estadio
{
    public partial class VerificarEntradas : Form
    {
        private const string CorrectPassword = "JK92xJ92";
        public VerificarEntradas()
        {
            InitializeComponent();

            RoundLabel(label8, 2);
            RoundButton(btnRegresarSS, 20);
            RoundButton(btncontinuar, 20);
            RoundTextBox(textBox1, 2);

            btnRegresarSS.BackColor = Colores.MintGreen;
            btncontinuar.BackColor = Colores.PeachOrange;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            El_Salvador_vs_Argentina ventana2 = new El_Salvador_vs_Argentina();
            ventana2.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            El_Salvador_vs_Argentina ventana2 = new El_Salvador_vs_Argentina();
            ventana2.Show();

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

        private void btnRegresarSS_Click(object sender, EventArgs e)
        {
            El_Salvador_vs_Argentina ventana2 = new El_Salvador_vs_Argentina();
            ventana2.Show();

            this.Hide();
        }

        private void VerificarEntradas_Load(object sender, EventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            string enteredText = textBox1.Text;

            if (enteredText == CorrectPassword)
            {
                Codigo_Aceptado newForm = new Codigo_Aceptado();
                newForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intenta de nuevo.");
                textBox1.Clear();
            }

        }
    }
}
