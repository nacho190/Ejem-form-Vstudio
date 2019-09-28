namespace Practica1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.insertar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.nombre_largo = new System.Windows.Forms.Button();
            this.per_alta = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dnibox = new System.Windows.Forms.TextBox();
            this.esdni = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.paneldni = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmos = new System.Windows.Forms.Panel();
            this.cerrarcua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cuadromos = new System.Windows.Forms.TextBox();
            this.Eliminarper = new System.Windows.Forms.Button();
            this.paneleliminar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dnidel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneldni.SuspendLayout();
            this.panelmos.SuspendLayout();
            this.paneleliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertar
            // 
            this.insertar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertar.Location = new System.Drawing.Point(39, 97);
            this.insertar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(230, 47);
            this.insertar.TabIndex = 0;
            this.insertar.Text = "Insertar persona";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // mostrar
            // 
            this.mostrar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(39, 205);
            this.mostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(230, 47);
            this.mostrar.TabIndex = 2;
            this.mostrar.Text = "Mostrar personas";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // consultar
            // 
            this.consultar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(39, 259);
            this.consultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(230, 47);
            this.consultar.TabIndex = 3;
            this.consultar.Text = "Consultar por dni";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // nombre_largo
            // 
            this.nombre_largo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_largo.Location = new System.Drawing.Point(39, 313);
            this.nombre_largo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombre_largo.Name = "nombre_largo";
            this.nombre_largo.Size = new System.Drawing.Size(230, 47);
            this.nombre_largo.TabIndex = 4;
            this.nombre_largo.Text = "Persona con el nombre mas largo";
            this.nombre_largo.UseVisualStyleBackColor = true;
            this.nombre_largo.Click += new System.EventHandler(this.Nombre_largo_Click);
            // 
            // per_alta
            // 
            this.per_alta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per_alta.Location = new System.Drawing.Point(39, 151);
            this.per_alta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.per_alta.Name = "per_alta";
            this.per_alta.Size = new System.Drawing.Size(230, 47);
            this.per_alta.TabIndex = 1;
            this.per_alta.Text = "Persona mas alta";
            this.per_alta.UseVisualStyleBackColor = true;
            this.per_alta.Click += new System.EventHandler(this.Per_alta_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(39, 437);
            this.salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(230, 47);
            this.salir.TabIndex = 5;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dnibox
            // 
            this.dnibox.Location = new System.Drawing.Point(29, 29);
            this.dnibox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dnibox.Name = "dnibox";
            this.dnibox.Size = new System.Drawing.Size(137, 25);
            this.dnibox.TabIndex = 7;
            // 
            // esdni
            // 
            this.esdni.AutoSize = true;
            this.esdni.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esdni.Location = new System.Drawing.Point(38, 7);
            this.esdni.Name = "esdni";
            this.esdni.Size = new System.Drawing.Size(128, 18);
            this.esdni.TabIndex = 8;
            this.esdni.Text = "Escribe el dni ";
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(14, 61);
            this.aceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(77, 26);
            this.aceptar.TabIndex = 9;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // paneldni
            // 
            this.paneldni.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paneldni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldni.Controls.Add(this.cerrar);
            this.paneldni.Controls.Add(this.dnibox);
            this.paneldni.Controls.Add(this.aceptar);
            this.paneldni.Controls.Add(this.esdni);
            this.paneldni.Location = new System.Drawing.Point(275, 235);
            this.paneldni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paneldni.Name = "paneldni";
            this.paneldni.Size = new System.Drawing.Size(202, 106);
            this.paneldni.TabIndex = 11;
            this.paneldni.Visible = false;
            // 
            // cerrar
            // 
            this.cerrar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(97, 61);
            this.cerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(80, 26);
            this.cerrar.TabIndex = 10;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "MENU";
            // 
            // panelmos
            // 
            this.panelmos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelmos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmos.Controls.Add(this.cerrarcua);
            this.panelmos.Controls.Add(this.label2);
            this.panelmos.Controls.Add(this.cuadromos);
            this.panelmos.Location = new System.Drawing.Point(508, 30);
            this.panelmos.Name = "panelmos";
            this.panelmos.Size = new System.Drawing.Size(289, 244);
            this.panelmos.TabIndex = 13;
            this.panelmos.Visible = false;
            // 
            // cerrarcua
            // 
            this.cerrarcua.Location = new System.Drawing.Point(87, 212);
            this.cerrarcua.Name = "cerrarcua";
            this.cerrarcua.Size = new System.Drawing.Size(75, 23);
            this.cerrarcua.TabIndex = 2;
            this.cerrarcua.Text = "Cerrar";
            this.cerrarcua.UseVisualStyleBackColor = true;
            this.cerrarcua.Click += new System.EventHandler(this.cerrarcua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // cuadromos
            // 
            this.cuadromos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuadromos.Location = new System.Drawing.Point(27, 51);
            this.cuadromos.Multiline = true;
            this.cuadromos.Name = "cuadromos";
            this.cuadromos.ReadOnly = true;
            this.cuadromos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cuadromos.Size = new System.Drawing.Size(235, 155);
            this.cuadromos.TabIndex = 0;
            // 
            // Eliminarper
            // 
            this.Eliminarper.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarper.Location = new System.Drawing.Point(39, 368);
            this.Eliminarper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eliminarper.Name = "Eliminarper";
            this.Eliminarper.Size = new System.Drawing.Size(230, 47);
            this.Eliminarper.TabIndex = 14;
            this.Eliminarper.Text = "Eliminar persona";
            this.Eliminarper.UseVisualStyleBackColor = true;
            this.Eliminarper.Click += new System.EventHandler(this.Eliminarper_Click_1);
            // 
            // paneleliminar
            // 
            this.paneleliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paneleliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneleliminar.Controls.Add(this.button2);
            this.paneleliminar.Controls.Add(this.button1);
            this.paneleliminar.Controls.Add(this.label3);
            this.paneleliminar.Controls.Add(this.dnidel);
            this.paneleliminar.Location = new System.Drawing.Point(275, 235);
            this.paneleliminar.Name = "paneleliminar";
            this.paneleliminar.Size = new System.Drawing.Size(202, 106);
            this.paneleliminar.TabIndex = 15;
            this.paneleliminar.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.closedel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Aceptareli_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Escribe el dni";
            // 
            // dnidel
            // 
            this.dnidel.Location = new System.Drawing.Point(29, 41);
            this.dnidel.Name = "dnidel";
            this.dnidel.Size = new System.Drawing.Size(137, 25);
            this.dnidel.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.paneleliminar);
            this.Controls.Add(this.Eliminarper);
            this.Controls.Add(this.panelmos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paneldni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.per_alta);
            this.Controls.Add(this.nombre_largo);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.insertar);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneldni.ResumeLayout(false);
            this.paneldni.PerformLayout();
            this.panelmos.ResumeLayout(false);
            this.panelmos.PerformLayout();
            this.paneleliminar.ResumeLayout(false);
            this.paneleliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button nombre_largo;
        private System.Windows.Forms.Button per_alta;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox dnibox;
        private System.Windows.Forms.Label esdni;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Panel paneldni;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelmos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuadromos;
        private System.Windows.Forms.Button cerrarcua;
        private System.Windows.Forms.Button Eliminarper;
        private System.Windows.Forms.Panel paneleliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dnidel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}