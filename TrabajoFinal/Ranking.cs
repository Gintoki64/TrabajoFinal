using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index form = new index();
            this.Hide();
            form.ShowDialog();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Label Titulo = this.Controls.Find("Puesto"+(i+1), true).FirstOrDefault() as Label;
                Titulo.Text = (Conexion.queryF("SELECT TOP (10) [Titulo] FROM[BBDDVideojuegos].[pepe].[video_games] order by Puntuacion desc; ")[i].ToString());
                Label TituloN = this.Controls.Find("Nota" +(i+1), true).FirstOrDefault() as Label;
                TituloN.Text = (Conexion.queryF("SELECT TOP (10) [Puntuacion] FROM[BBDDVideojuegos].[pepe].[video_games] order by Puntuacion desc; ")[i].ToString());

            }
        }
    }
}
