namespace Practica1
{
    partial class mostrarPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mostrarPersonas));
            this.personas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.USUARIOS = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personas
            // 
            this.personas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.personas.Cursor = System.Windows.Forms.Cursors.Default;
            this.personas.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personas.ForeColor = System.Drawing.Color.Black;
            this.personas.Location = new System.Drawing.Point(31, 44);
            this.personas.Multiline = true;
            this.personas.Name = "personas";
            this.personas.ReadOnly = true;
            this.personas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.personas.Size = new System.Drawing.Size(378, 371);
            this.personas.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // USUARIOS
            // 
            this.USUARIOS.AutoSize = true;
            this.USUARIOS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIOS.ForeColor = System.Drawing.Color.Black;
            this.USUARIOS.Location = new System.Drawing.Point(524, 92);
            this.USUARIOS.Name = "USUARIOS";
            this.USUARIOS.Size = new System.Drawing.Size(116, 23);
            this.USUARIOS.TabIndex = 1;
            this.USUARIOS.Text = "USUARIOS";
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.Black;
            this.salir.Location = new System.Drawing.Point(636, 387);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(125, 28);
            this.salir.TabIndex = 0;
            this.salir.Text = "CERRAR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // mostrarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.USUARIOS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personas);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "mostrarPersonas";
            this.Text = "mostrarPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label USUARIOS;
        private System.Windows.Forms.Button salir;
    }
}