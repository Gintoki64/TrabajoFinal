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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarVideojuego insertarVideojuego = new InsertarVideojuego();
            this.Hide();
            insertarVideojuego.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarMenu eliminarMenu = new EliminarMenu();
            this.Hide();
            eliminarMenu.ShowDialog(); 
        }


        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            this.Hide();
            ranking.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscarVideojuego buscarVideojuego = new BuscarVideojuego();
            this.Hide();
            buscarVideojuego.ShowDialog();
        }
    }
}
