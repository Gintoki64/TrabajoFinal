namespace TrabajoFinal
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.titulo = new System.Windows.Forms.PictureBox();
            this.NombreInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonLogin = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Image = global::TrabajoFinal.Properties.Resources.dde;
            this.titulo.Location = new System.Drawing.Point(12, 53);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1217, 155);
            this.titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titulo.TabIndex = 0;
            this.titulo.TabStop = false;
            // 
            // NombreInput
            // 
            this.NombreInput.Location = new System.Drawing.Point(309, 408);
            this.NombreInput.Name = "NombreInput";
            this.NombreInput.Size = new System.Drawing.Size(581, 27);
            this.NombreInput.TabIndex = 1;
            this.NombreInput.TextChanged += new System.EventHandler(this.NombreInput_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(581, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(552, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(530, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD:";
            // 
            // botonLogin
            // 
            this.botonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonLogin.Location = new System.Drawing.Point(530, 668);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(145, 75);
            this.botonLogin.TabIndex = 5;
            this.botonLogin.Text = "ENTRAR";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonSalir.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(1101, 827);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(111, 55);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "SALIR";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 933);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NombreInput);
            this.Controls.Add(this.titulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginBBDD";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox titulo;
        private TextBox NombreInput;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button botonLogin;
        private Button botonSalir;
        private ErrorProvider errorProvider1;
    }
}