
namespace TrabajoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void NombreInput_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void ControlBotones()
        {
            if (NombreInput.Text.Trim() != String.Empty && NombreInput.Text.All(Char.IsLetter))
            {
                botonLogin.Enabled = true;
                errorProvider1.SetError(NombreInput, "");
            }
            else
            {
                if (!(NombreInput.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(NombreInput, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(NombreInput, "Debe introducir su nombre");
                }
                botonLogin.Enabled = false;
                NombreInput.Focus();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List <string> listaLogin = new List<string>();
            listaLogin= Conexion.queryF("SELECT * FROM usuario").Select(i => i.ToString()).ToList();
            if (listaLogin[0] == NombreInput.Text && listaLogin[1] == passwordInput.Text)
            {
                index form = new index();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error introduciendo la contraseña o el usuario");
            }
        }


        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            botonLogin.Enabled = false;
            Conexion.Conectar();
            try
            {
                Conexion.Conectar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}