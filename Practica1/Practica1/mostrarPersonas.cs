using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class mostrarPersonas : Form
    {
       public List<Persona> list;
       public int cont = 1;
        public mostrarPersonas(List<Persona> x)
        {
            InitializeComponent();
            list = x;           
            foreach (var i in list)//recorre la lista de personas y las escribe en el textbox
            {
                personas.Text = personas.Text + "USUARIO Nº " + cont
                    + "\r\nNombre: " + i.nombre
                    + "\r\nApellidos: " + i.apellidos
                    + "\r\nDNI: " + i.dni
                    + "\r\nFecha de nacimiento: " + i.fecha
                    + "\r\nPeso: " + i.peso
                    + "\r\nAltura: " + i.altura
                    + "\r\n-------------------\r\n";
                cont++;
            }
            if(list.Count == 0)
            {
                personas.Font = new Font("Consolas", 13, FontStyle.Bold);//Cambio estilo de letra para el texto mostrarpersonas
                personas.Text = "0 Usuarios";
            }
           // personas.SelectionStart = 0;   pone el cursor al principio
            personas.Select(personas.TextLength, 0);     //quita la seleccion del texto del textbox
         }

        private void salir_Click(object sender, EventArgs e)//salir
        {
            this.Close();
        }
    }
}
