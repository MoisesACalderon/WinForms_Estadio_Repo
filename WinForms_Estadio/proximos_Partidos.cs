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
    public partial class proximos_Partidos : Form
    {
        public proximos_Partidos()
        {
            InitializeComponent();
            rellenartabla();

            RoundButton(btnregresar, 20);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void rellenartabla()
        {
            List<Cartelera_de_partidos> cartelera = new List<Cartelera_de_partidos>();
            cartelera.Add(new Cartelera_de_partidos("13/6/24", " 18:30", "El Salvador vs Argentina", "Amistoso", "Estadio Cuscatlan(El Salvador)", "Si"));

            foreach (Cartelera_de_partidos p in cartelera)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = p.Fecha;
                row.Cells[1].Value = p.Hora;
                row.Cells[2].Value = p.juegan;
                row.Cells[3].Value = p.Tipo_de_partido;
                row.Cells[4].Value = p.Lugar;
                row.Cells[5].Value = p.Entradas_Disponibles;

            }
        }

        private void proximos_Partidos_Load(object sender, EventArgs e)
        {
            AjustaTamañoTabla();
        }

        private void AjustaTamañoTabla()
        {
            var height = dataGridView1.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                height += dr.Height;
            }
            dataGridView1.Height = height;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 ventana2 = new Form1();
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
    }
}
