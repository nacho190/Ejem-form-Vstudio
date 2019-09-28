namespace Practica1
{
   public partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.boton_crear = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(355, 127);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 0;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(355, 155);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(100, 22);
            this.apellidos.TabIndex = 1;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(355, 183);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 22);
            this.dni.TabIndex = 2;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(355, 239);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(100, 22);
            this.peso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Peso(kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Altura(cm)";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(355, 267);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 22);
            this.altura.TabIndex = 5;
            // 
            // boton_crear
            // 
            this.boton_crear.Location = new System.Drawing.Point(287, 326);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(120, 23);
            this.boton_crear.TabIndex = 6;
            this.boton_crear.Text = "Crear persona";
            this.boton_crear.UseVisualStyleBackColor = true;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // registro
            // 
            this.registro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(307, 44);
            this.registro.MaximumSize = new System.Drawing.Size(200, 200);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(200, 62);
            this.registro.TabIndex = 14;
            this.registro.Text = "REGISTRO";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(413, 326);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(120, 23);
            this.close.TabIndex = 7;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(356, 211);
            this.fecha.Mask = "00/00/0000";
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 22);
            this.fecha.TabIndex = 3;
            this.fecha.ValidatingType = typeof(System.DateTime);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.close);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.boton_crear);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Name = "Login";
            this.Text = "LOG IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.Label registro;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.MaskedTextBox fecha;
    }
}

