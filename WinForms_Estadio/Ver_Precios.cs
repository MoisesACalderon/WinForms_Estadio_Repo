﻿using System;
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
    public partial class Ver_Precios : Form
    {
        public Ver_Precios()
        {
            InitializeComponent();
            rellenartabla2();

            RoundButton(btnregresar, 20);

            btnregresar.BackColor = Colores.MintGreen;
        }

        private void Ver_Precios_Load(object sender, EventArgs e)
        {

        }

        private void ajustardatos()
        {
            var height = dataGridView1.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                height += dr.Height;
            }
            dataGridView1.Height = height;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void rellenartabla2()
        {
            List<Precios_Partidos> precios_zonas = new List<Precios_Partidos>();
            precios_zonas.Add(new Precios_Partidos("Sol General", "200.00 USD", "185.00 USD", "165.00 USD"));
            precios_zonas.Add(new Precios_Partidos("Sol Preferente Norte y Sur", "250.00 USD", "235.00 USD", "225.00 USD"));
            precios_zonas.Add(new Precios_Partidos("Sombra Norte y Sur", "275.00 USD", "260.00 USD", "245.00 USD"));
            precios_zonas.Add(new Precios_Partidos("Tribuna Preferente Norte y Sur", "375.00 USD", "360.00 USD", "345.00 USD"));
            precios_zonas.Add(new Precios_Partidos("Platea", "475.00 USD", "460.00 USD", "445.00 USD"));

            foreach (Precios_Partidos p in precios_zonas)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = p.Zona;
                row.Cells[1].Value = p.Precios_Adultos;
                row.Cells[2].Value = p.Precios_Niños;
                row.Cells[3].Value = p.Precios_Discapacitados;

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
