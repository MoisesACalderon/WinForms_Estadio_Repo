using System.Drawing.Drawing2D;

namespace WinForms_Estadio
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            RoundButton(btnproximospartidos, 20);
            RoundButton(btnreservarentradas, 20);

            btnproximospartidos.BackColor = Colores.SalmonPink;
            btnreservarentradas.BackColor = Colores.PeachOrange;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnproximospartidos_Click(object sender, EventArgs e)
        {
            proximos_Partidos ventana = new proximos_Partidos();
            ventana.Show();

            this.Hide();
        }

        private void btnReservarEntradas_Click(object sender, EventArgs e)
        {
            Reservar_Entradas ventana1 = new Reservar_Entradas();
            ventana1.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
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
