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
    public partial class Menu : Form
    {
        public List<Persona> lista = new List<Persona>();
        public String nombrelargo = "";
        public int alturamax = 0;
        Login log;
        bool crea;

        public Menu()
        {
            InitializeComponent();
        }
        private void Insertar_Click(object sender, EventArgs e)//Abre el formulario del Login, oculta Menu y al cerrar el login, Menu se vuelve a abrir
        {
            log = new Login(lista);
            this.Hide();
            log.ShowDialog();
            this.Show();        
        }
        public void Per_alta_Click(object sender, EventArgs e)//muestra la persona/s mas alta en un messagebox
        {
            panelmos.Visible = true;
            cerrarcua.Focus();
            if (lista.Count > 0)
            {
            for (int i = 0; i < lista.Count(); i++)//Guardo la persona mas alta
            {
                if (lista[i].altura > alturamax)
                {
                    alturamax = lista[i].altura;
                }
            }
            for (int i = 0; i < lista.Count(); i++)//Compruebo si hay alguien igual de alto y los imprimo
            {
                if (lista[i].altura == alturamax)
                {
                        cuadromos.Text = cuadromos.Text + "Nombre: " + lista[i].nombre + "\r\nApellidos: " 
                            + lista[i].apellidos+"\r\nDni: "+ lista[i].dni+ "\r\nFecha: "+ lista[i].fecha 
                            +"\r\nPeso: "+lista[i].peso+"\r\nAltura: "+lista[i].altura+"\r\n\r\n";
                        MessageBox.Show("Persona/s mas alta es: " + lista[i].nombre + " " + lista[i].apellidos,
                            "Persona mas alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            }
            else
            {
                MessageBox.Show("No hay registrada ninguna persona", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)//muestra todas las personas registradas
        {
            mostrarPersonas mostrar = new mostrarPersonas(lista);
            this.Hide();
            mostrar.ShowDialog();
            this.Show();
            
        }

        private void Consultar_Click(object sender, EventArgs e)//boton para abrir el cuadro del dni
        {
        
            paneldni.Visible = true;
            dnibox.Focus();
        }
        private void Aceptar_Click(object sender, EventArgs e)//boton "aceptar" del cuadro para consultar el dni
        {
            if (log != null) { //compruebo si el Login se ha creado para que no de error en caso de no haberse abierto
            crea = log.creado;//le asigno a crea el valor "true" si se ha registrado alguien o "false" si no
            }
            if (dnibox.Text == "")
            {
                MessageBox.Show("Campo vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dnibox.Focus();
            }
            else if (crea == false)
            {
                MessageBox.Show("No hay registrada ninguna persona", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dnibox.Text = "";
                dnibox.Focus();
            }
            else
            {
                string dni = dnibox.Text;
                dnibox.Text = "";
                dnibox.Focus();
                foreach (var i in lista)
                {
                    if (dni.ToLower() == i.dni.ToLower()) 
                    {
                        MessageBox.Show("Usuario: " + i.nombre + " " + i.apellidos, "Busqueda por dni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        
                    }             
                }

                    MessageBox.Show("El dni no coincide", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }
            
        }
        private void Nombre_largo_Click(object sender, EventArgs e)//boton para consular el nombre mas largo
        {
            panelmos.Visible = true;
            cerrarcua.Focus();

            if (lista.Count > 0)
            {
                foreach (var i in lista)//guardo el nombre mas alto
            {
                if(i.nombre.Length > nombrelargo.Length)
                {
                    nombrelargo = i.nombre;
                }
            }
            foreach (var i in lista)//Compruebo si hay otros nombres con la misma longitud que nombrelargo y los imprimo
            {
                if (i.nombre.Length == nombrelargo.Length)
                {
                    nombrelargo = i.nombre;
                        cuadromos.Text = cuadromos.Text + "Nombre: " + i.nombre + "\r\nApellidos: " + i.apellidos
                            + "\r\nDni: " + i.dni + "\r\nFecha: " + i.fecha + "\r\nPeso: "
                            + i.peso + "\r\nAltura: " + i.altura+"\r\n\r\n";
                        MessageBox.Show("Persona/s con el nombre mas largo " + nombrelargo + " " + i.apellidos,
                            "Nombre mas largo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
            }
            else
            {
                MessageBox.Show("No hay registrada ninguna persona", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)//boton para ocultar el cuadro del dni
        {
            
            paneldni.Visible = false;
        }

        private void Salir_Click(object sender, EventArgs e)//salir
        {
            this.Close();
        }

        private void Eliminarper_Click_1(object sender, EventArgs e)//Boton para eliminar personas
        {
            paneleliminar.Visible = true;
            dnidel.Focus();
        }

        private void cerrarcua_Click(object sender, EventArgs e)//cerrar el cuadro de eliminar personas
        {
            panelmos.Visible = false;
            
            cuadromos.Text = "";
        }

        private void Aceptareli_Click(object sender, EventArgs e)//elimina la persona del dni introducido comprobando que sea correcto
        {
            string dnieli = dnidel.Text;
            if (log != null)
            { 
                crea = log.creado;
            }
            if (dnidel.Text == "" || crea == false)
            {
                MessageBox.Show("Dni mal introducido o no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dnidel.Text = "";
                dnidel.Focus();
                return;
            }
            foreach (var i in lista)
            {
                if (i.dni.ToLower() == dnieli.ToLower())
                {
                    lista.Remove(i);
                    MessageBox.Show("Usuario Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dnidel.Text = "";
                    dnidel.Focus();
                    return;
                }              
            }
            MessageBox.Show("Dni mal introducido o no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dnidel.Text = "";
            dnidel.Focus();
        }

        private void closedel_Click(object sender, EventArgs e)//cierra el panel de eliminar per
        {
            paneleliminar.Visible = false;

        }
    }
    }

