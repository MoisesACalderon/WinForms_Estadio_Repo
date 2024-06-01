namespace WinForms_Estadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
