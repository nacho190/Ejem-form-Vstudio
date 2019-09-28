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
    public partial class Login : Form
    {
        public List<Persona> list;
        public bool creado;
        public Login(List<Persona> p)
        {
            InitializeComponent();
            list = p;

        }

        private void boton_crear_Click(object sender, EventArgs e)//crea la persona si los campos son correctos
        {
            creado = false;
            bool dnirepe = false;//variable para saber si el dni esta repetido
            bool letradni = false;
            string nom = nombre.Text;
            string ape = apellidos.Text;
            string id = dni.Text;
            string fech = fecha.Text;
            int pes;
            int altu;
            char[] contfecha = fech.ToCharArray();
            char[] contnom = nom.ToCharArray();
            char[] contape = ape.ToCharArray();
            if (nombre.Text == "" || contnom.Length < 3)//Comprueba que el formato del nombre este bien
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre.Text = "";
                nombre.Focus();
                return;
            }
            if (apellidos.Text == "" || contape.Length < 3)//Comprueba que el formato del apellido este bien
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                apellidos.Text = "";
                apellidos.Focus();
                return;
            }
            if (dni.Text == "")
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni.Text = "";
                dni.Focus();
                return;
            }
            string letra = id.Substring(id.Length - 1);//le asigno a "letra" el ultimo caracter del dni
            char le = letra.ToCharArray()[0];
            char l = 'a';
            char m = 'A';
            char[] listanum = dni.Text.ToCharArray();
            bool numeros = false;
            int contadornum = 0;

                for (int i = 0; i < listanum.Length -1; i++)//Compruebo que los 8 primeros caracteres del dni sean numeros
                {
                    if (listanum[i] >= 48 && listanum[i] <= 57)
                    {
                        contadornum++;
                        if(contadornum == 8)
                        {
                            numeros = true;
                        }
                    }
                }        
            while (l <= 'z')//Compruebo si la ultima posicion del dni es una letra minuscula
            {
                if (le == l)
                {
                    letradni = true;
                }
                l++;
            }
            while (m <= 'Z')//Compruebo si la ultima posicion del dni es letra mayuscula
            {
                if (le == m)
                {
                    letradni = true;
                }
                m++;
            }
            foreach (var i in list)//recorre la lista de personas comprobando si hay algun dni repetido
            {
                if (i.dni.ToLower() == dni.Text.ToLower())
                {
                    dnirepe = true;
                }
            }
            if (dni.Text.Length != 9 || letradni != true || numeros != true)//compruebo que el formato del dni sea correcto
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni.Text = "";
                dni.Focus();
                return;
            }
            else if (dnirepe == true)//Compruebo si el dni esta repetido
            {
                MessageBox.Show("El dni esta repetido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni.Text = "";
                dni.Focus();
                return;
            }

            if (contfecha.Length < 10)//Compruebo que el formato de la fecha sea correcta
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fecha.Text = "";
                fecha.Focus();
                return;
            }
            try
            {
                pes = Convert.ToInt32(peso.Text);
                if (pes > 300 || pes < 20)
                {
                    MessageBox.Show("Escribe un peso razonable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    peso.Text = "";
                    peso.Focus();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                peso.Text = "";
                peso.Focus();
                return;
            }
            try
            {
                altu = Convert.ToInt32(altura.Text);
                //altu = int.Parse(altura.Text);
                if (altu > 300 || altu < 20)
                {
                    MessageBox.Show("Escribe una altura razonable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    altura.Text = "";
                    altura.Focus();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                altura.Text = "";
                altura.Focus();
                return;
            }

            list.Add(new Persona(nom, ape, id, fech, pes, altu));
            creado = true;
            nombre.Text = "";
            apellidos.Text = "";
            dni.Text = "";
            fecha.Text = "";
            peso.Text = "";
            altura.Text = "";
            nombre.Focus();
            MessageBox.Show("Has creado a " + nom + " " + ape, "CREADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Close_Click(object sender, EventArgs e)//salir
        {
            this.Close();
        }

    }
}
