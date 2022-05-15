namespace TrabajoFinal
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.botonInsertar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botonInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertar.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonInsertar.Location = new System.Drawing.Point(114, 44);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(984, 155);
            this.botonInsertar.TabIndex = 0;
            this.botonInsertar.Text = "INSERTAR REGISTRO";
            this.botonInsertar.UseVisualStyleBackColor = false;
            this.botonInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(114, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(984, 155);
            this.button1.TabIndex = 1;
            this.button1.Text = "BUSCAR VIDEOJUEGO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(114, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(984, 155);
            this.button2.TabIndex = 2;
            this.button2.Text = "ELIMINAR VIDEOJUEGO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(114, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(984, 155);
            this.button3.TabIndex = 3;
            this.button3.Text = "RANKING DE MEJORES JUEGOS";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // botonSalir
            // 
            this.botonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonSalir.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(1087, 828);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(111, 55);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.Text = "SALIR";
            this.botonSalir.UseVisualStyleBackColor = false;
            // 
            // index
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 933);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonInsertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "index";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button botonInsertar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button botonSalir;
    }
}