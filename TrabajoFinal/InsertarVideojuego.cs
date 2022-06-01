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
    public partial class InsertarVideojuego : Form
    {
        public InsertarVideojuego()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (insertTitulo.Text.Length >0 && InsertEmpresa.Text.Length>0 && InsertFecha.Value.Year >0 && InsertPlataforma.Text.Length >0)
            {
                Conexion.queryF("INSERT INTO[pepe].[video_games]([Titulo],[Empresa],[Anyo],[Genero],[Plataforma],[Multijugador],[Puntuacion])" +
                    "   VALUES('"+insertTitulo.Text+"','"+InsertEmpresa.Text+"','"+InsertFecha.Value.Year.ToString()+"','"+InsertGenero.Text+"','"
                    +InsertPlataforma.Text+"','true',0); ");
                MessageBox.Show("Insertado con exito");

            }
            else
            {
                MessageBox.Show("Error introduciendo los datos, asegurese de introducirlos todos");

            }
        }

        private void insertTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
