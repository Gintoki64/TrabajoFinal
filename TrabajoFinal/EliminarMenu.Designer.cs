namespace TrabajoFinal
{
    partial class EliminarMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eliminarJuegoText = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonBuscarE = new System.Windows.Forms.Button();
            this.Comprobacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elige el juego que deseas eliminar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 691);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // eliminarJuegoText
            // 
            this.eliminarJuegoText.Location = new System.Drawing.Point(12, 265);
            this.eliminarJuegoText.Name = "eliminarJuegoText";
            this.eliminarJuegoText.Size = new System.Drawing.Size(622, 27);
            this.eliminarJuegoText.TabIndex = 4;
            this.eliminarJuegoText.TextChanged += new System.EventHandler(this.eliminarJuegoText_TextChanged);
            // 
            // botonSalir
            // 
            this.botonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonSalir.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(1081, 814);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(111, 55);
            this.botonSalir.TabIndex = 9;
            this.botonSalir.Text = "SALIR";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonBuscarE
            // 
            this.botonBuscarE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonBuscarE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonBuscarE.Location = new System.Drawing.Point(188, 395);
            this.botonBuscarE.Name = "botonBuscarE";
            this.botonBuscarE.Size = new System.Drawing.Size(277, 44);
            this.botonBuscarE.TabIndex = 10;
            this.botonBuscarE.Text = "buscar";
            this.botonBuscarE.UseVisualStyleBackColor = false;
            this.botonBuscarE.Click += new System.EventHandler(this.botonBuscarE_Click);
            // 
            // Comprobacion
            // 
            this.Comprobacion.AutoSize = true;
            this.Comprobacion.BackColor = System.Drawing.Color.Transparent;
            this.Comprobacion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Comprobacion.Location = new System.Drawing.Point(37, 493);
            this.Comprobacion.Name = "Comprobacion";
            this.Comprobacion.Size = new System.Drawing.Size(0, 31);
            this.Comprobacion.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(188, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(884, 814);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "VOLVER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.labelBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBusqueda.Location = new System.Drawing.Point(188, 500);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(0, 23);
            this.labelBusqueda.TabIndex = 14;
            // 
            // EliminarMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 933);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Comprobacion);
            this.Controls.Add(this.botonBuscarE);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.eliminarJuegoText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EliminarMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox eliminarJuegoText;
        private Button botonSalir;
        private Button botonBuscarE;
        private Label Comprobacion;
        private Button button1;
        private Button button2;
        private Label labelBusqueda;
    }
}