using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVeterinaria
{
    public partial class Principal : Form
    {
        List<Dueño> dueños = new List<Dueño>();
        List<Mascota> mascotas = new List<Mascota>();

        public Principal()
        {
            InitializeComponent();
        }

        void Mostrar(ListView list, string type)
        {
            if (type == "dueño")
            {
                list.Items.Clear();

                for (int i = 0; i < dueños.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dueños[i].nombre);
                    item.SubItems.Add(dueños[i].direccion);
                    item.SubItems.Add(dueños[i].telefono);

                    list.Items.Add(item);
                }
            }

            else if (type == "mascota")
            {
                list.Items.Clear();

                for (int i = 0; i < mascotas.Count; i++)
                {
                    ListViewItem item = new ListViewItem(mascotas[i].nombre);
                    item.SubItems.Add(mascotas[i].edad);
                    item.SubItems.Add(mascotas[i].raza);
                    item.SubItems.Add(mascotas[i].dueño);

                    list.Items.Add(item);
                }
            }
        }

        void Buscar()
        {
            string busqueda = txtMostrarNombreMascota.Text;
            bool encontrado = false;

            int ind = 0;

            while (ind < mascotas.Count)
            {   
                if (busqueda == mascotas[ind].nombre)
                {
                    encontrado = true;

                    txtMostrarNombreDueño.Text = dueños[ind].nombre;
                    txtMostrarDireccion.Text = dueños[ind].direccion;
                    txtMostrarTelefono.Text = dueños[ind].telefono;

                    txtMostrarEdad.Text = mascotas[ind].edad;
                    txtMostrarRaza.Text = mascotas[ind].raza;
                }
                ind++;
            }

            if (encontrado)
            {
                MessageBox.Show($"Se ha encontrado a '{busqueda}'");
            } else
            {
                MessageBox.Show($"No se ha encontrado a '{busqueda}'");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreDueño.Text == "" || txtDireccionDueño.Text == "" || txtTelefonoDueño.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos.");
                } else
                {
                    string nombre = txtNombreDueño.Text;
                    string direccion = txtDireccionDueño.Text;
                    string telefono = txtTelefonoDueño.Text;

                    Dueño dn = new Dueño(nombre, direccion, telefono);
                    dueños.Add(dn);

                    MessageBox.Show("Dueño registrado correctamente.");

                    Mostrar(listViewDueños, "dueño");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error de formulario: " + ex.Message);
            } finally
            {
                txtNombreDueño.Text = "";
                txtDireccionDueño.Text = "";
                txtTelefonoDueño.Text = "";
            }
        }

        private void tabPageMascotas_FocusEnter(object sender, EventArgs e)
        {
            cbDueños.Items.Clear();

            if (dueños.Count > 0)
            {
                for (int i = 0; i < dueños.Count; i++)
                {
                    cbDueños.Items.Add(dueños[i].nombre);
                }
            }
            else
            {
                cbDueños.Items.Add("No hay registros.");
            }
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreMascota.Text == "" || txtEdadMascota.Text == "" || txtRazaMascota.Text == "" || cbDueños.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos.");
                } else
                {
                    string nombreMascota = txtNombreMascota.Text;
                    string edadMascota = txtEdadMascota.Text;
                    string razaMascota = txtRazaMascota.Text;
                    string dueñoMascota = cbDueños.Text;

                    Mascota masc = new Mascota(nombreMascota, edadMascota, razaMascota, dueñoMascota);
                    mascotas.Add(masc);

                    MessageBox.Show("Mascota registrada correctamente.");

                    Mostrar(listViewMascotas, "mascota");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error de formulario: " + ex.Message);
            } finally
            {
                txtNombreMascota.Text = "";
                txtEdadMascota.Text = "";
                txtRazaMascota.Text = "";
                cbDueños.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           try
           {
                if (txtMostrarNombreMascota.Text == "")
                {
                    MessageBox.Show("Escriba el nombre de la mascota.");
                }
                else
                {
                    Buscar();
                }
           } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
