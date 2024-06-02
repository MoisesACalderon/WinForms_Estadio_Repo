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
    public partial class menuZonas : Form
    {
        public menuZonas()
        {
            InitializeComponent();

            RoundButton(btnregresar, 20);

            RoundButton(btntribunasur, 20);
            RoundButton(btntribunanorte, 20);
            RoundButton(btnpreferentesur, 20);
            RoundButton(btnpreferentenorte, 20);
            RoundButton(btnsombrasur, 20);
            RoundButton(btnsombranorte, 20);
            RoundButton(btnplateas, 20);
            RoundButton(btnsolgeneral, 20);

            btnregresar.BackColor = Colores.MintGreen;

            btntribunasur.BackColor = Colores.SkyBlue;
            btntribunanorte.BackColor = Colores.SkyBlue;
            btnpreferentesur.BackColor = Colores.PeachOrange;
            btnpreferentenorte.BackColor = Colores.PeachOrange;
            btnsombrasur.BackColor = Colores.SalmonPink;
            btnsombranorte.BackColor = Colores.SalmonPink;
            btnplateas.BackColor = Colores.SoftLavender;
            btnsolgeneral.BackColor = Colores.SoftLavender;


        }

        private void menuZonas_Load(object sender, EventArgs e)
        {

        }

        private void btnTribunaSur_Click(object sender, EventArgs e)
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

        private void btnRegresarZ_Click(object sender, EventArgs e)
        {

        }

        private void TituloSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            AsientosPreferenteNorte asientosPreferenteNorte = new AsientosPreferenteNorte();
            asientosPreferenteNorte.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AsientosSolGeneral asientosSolGeneral = new AsientosSolGeneral();
            asientosSolGeneral.Show();
            this.Hide();
        }

        private void btntribunasur_Click_1(object sender, EventArgs e)
        {
            AsientosTribunaSur asientosTribunaSur = new AsientosTribunaSur();
            asientosTribunaSur.Show();
            this.Hide();
        }
        private void btntribunanorte_Click_1(object sender, EventArgs e)
        {
            AsientosTribunaNorte asientosTribunaNorte = new AsientosTribunaNorte();
            asientosTribunaNorte.Show();
            this.Hide();
        }
        private void btnpreferentesur_Click_1(object sender, EventArgs e)
        {
            AsientosPreferenteSur asientosPreferenteSur = new AsientosPreferenteSur();
            asientosPreferenteSur.Show();
            this.Hide();
        }
        private void btnpreferentenorte_Click_1(object sender, EventArgs e)
        {
            AsientosPreferenteNorte asientosPreferenteNorte = new AsientosPreferenteNorte();
            asientosPreferenteNorte.Show();
            this.Hide();
        }
        private void btnsolgenerl(object sender, EventArgs e)
        {
            AsientosSolGeneral asientosSolGeneral = new AsientosSolGeneral();
            asientosSolGeneral.Show();
            this.Hide();
        }
        private void btnplatea(object sender, EventArgs e)
        {
            AsientosPlatea asientosPlatea = new AsientosPlatea();
            asientosPlatea.Show();
            this.Hide();
        }
        private void btnsombrasur1(object sender, EventArgs e)
        {
            AsientosSombraSur asientosSombraSur = new AsientosSombraSur();
            asientosSombraSur.Show();
            this.Hide();
        }
        private void btnsombranorte1(object sender, EventArgs e)
        {
            AsientosSombraNorte asientosSombraNorte = new AsientosSombraNorte();
            asientosSombraNorte.Show();
            this.Hide();
        }


        private void btnregresar_Click(object sender, EventArgs e)
        {
            El_Salvador_vs_Argentina el_Salvador_Vs_Argentina = new El_Salvador_vs_Argentina();
            el_Salvador_Vs_Argentina.Show();
            this.Hide();
        }

        private void labelfiguralinea_Click(object sender, EventArgs e)
        {

        }

        private void btnsombrasur_Click(object sender, EventArgs e)
        {
            AsientosSombraSur asientosSombraSur = new AsientosSombraSur();
            asientosSombraSur.Show();
            this.Hide();
        }

        private void btnsombranorte_Click(object sender, EventArgs e)
        {
            AsientosSombraNorte asientosSombraNorte = new AsientosSombraNorte();
            asientosSombraNorte.Show();
            this.Hide();
        }

        private void btntribunanorte_Click(object sender, EventArgs e)
        {
            AsientosTribunaNorte asientosTribunaNorte = new AsientosTribunaNorte();
            asientosTribunaNorte.Show();
            this.Hide();
        }

        private void btnpreferentesur_Click(object sender, EventArgs e)
        {
            AsientosPreferenteSur asientosPreferenteSur = new AsientosPreferenteSur();
            asientosPreferenteSur.Show();
            this.Hide();
        }

        private void btnplateas_Click(object sender, EventArgs e)
        {
            AsientosPlatea asientosPlatea = new AsientosPlatea();
            asientosPlatea.Show();
            this.Hide();
        }
    }
}
