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
    public partial class EliminarMenu : Form
    {
        public EliminarMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void botonBuscarE_Click(object sender, EventArgs e)
        {
            if (eliminarJuegoText.Text != null)
            {
                try
                {
                    string buscador = "";
                    labelBusqueda.Text = (Conexion.queryF("SELECT TOP(1)[Titulo] FROM[BBDDVideojuegos].[pepe].[video_games]" +
                        " where Titulo = '" + eliminarJuegoText.Text + "'")[0].ToString());
                }catch (Exception ex)
                {
                    MessageBox.Show("Ese juego no existe");
                }
 }
            else
            {
                MessageBox.Show("Introduce un valor valido");
            }
        }

        private void eliminarJuegoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eliminarJuegoText.Text != null)
            {
                Conexion.queryF("DELETE FROM[pepe].[video_games] WHERE titulo = '" + eliminarJuegoText.Text + "';");
                MessageBox.Show("eliminado con exito");

            }
            else
            {
                MessageBox.Show("Escribe algo en el texto");

            }
        }
    }
}
