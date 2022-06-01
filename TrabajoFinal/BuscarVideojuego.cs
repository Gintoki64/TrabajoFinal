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
    public partial class BuscarVideojuego : Form
    {
        public BuscarVideojuego()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index form = new index();
            this.Hide();
            form.ShowDialog();
        }

        private void BuscarJuegoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (BuscarJuegoText.Text != null)
            {
                try
                {
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    Label Titulo = this.Controls.Find("info" + (i + 1), true).FirstOrDefault() as Label;
                    //    Titulo.Text = (Conexion.queryF("SELECT TOP (1) [Titulo] FROM[BBDDVideojuegos].[pepe].[video_games] orde; ")[i].ToString());
                    //}


                    info1.Text = (Conexion.queryF("SELECT TOP(1) * FROM[BBDDVideojuegos].[pepe].[video_games] where Titulo = '" + BuscarJuegoText.Text + "'")[0].ToString());
                    info2.Text = (Conexion.queryF("SELECT TOP(1) * FROM[BBDDVideojuegos].[pepe].[video_games] where Titulo = '" + BuscarJuegoText.Text + "'")[1].ToString());
                    info3.Text = (Conexion.queryF("SELECT TOP(1) * FROM[BBDDVideojuegos].[pepe].[video_games] where Titulo = '" + BuscarJuegoText.Text + "'")[2].ToString());
                    info4.Text = (Conexion.queryF("SELECT TOP(1) * FROM[BBDDVideojuegos].[pepe].[video_games] where Titulo = '" + BuscarJuegoText.Text + "'")[3].ToString());
                    info5.Text = (Conexion.queryF("SELECT TOP(1) * FROM[BBDDVideojuegos].[pepe].[video_games] where Titulo = '" + BuscarJuegoText.Text + "'")[4].ToString());
                    info7.Text = (Conexion.queryF("SELECT TOP(1) * FROM[BBDDVideojuegos].[pepe].[video_games] where Titulo = '" + BuscarJuegoText.Text + "'")[6].ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ese juego no existe");
                }
            }
            else
            {
                MessageBox.Show("Introduce un valor valido");
            }
        }

        private void BuscarVideojuego_Load(object sender, EventArgs e)
        {

        }
    }
}
