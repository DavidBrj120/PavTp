using PavTpGrupo11.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavTpGrupo11.Formularios
{
    public partial class ABM_materialescs : Form
    {

        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_materialescs()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ABM_materialescs_Load(object sender, EventArgs e)
        {
            grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Equals("") || txtCodigo.Text.Equals("") || txtCodProv.Text.Equals("") || txtPrecio.Text.Equals("") || txtUnidadMedida.Text.Equals("") || txtDataTime.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta del Material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.InsertarMaterial(txtCodigo.Text, txtCantidad.Text, txtUnidadMedida.Text, txtCodProv.Text, txtDataTime.Value.ToString(), txtPrecio.Text); 
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el material con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
                grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
            }
        grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        private void txtDataTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Equals("") || txtCodigo.Text.Equals("") || txtCodProv.Text.Equals("") || txtPrecio.Text.Equals("") || txtUnidadMedida.Text.Equals("") || txtDataTime.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar el Material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.ModificarMaterial(txtCodigo.Text, txtCantidad.Text, txtUnidadMedida.Text, txtCodProv.Text, txtDataTime.Value.ToString(), txtPrecio.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado el Material con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
                grillaMateriales.DataSource = cn.ConsultarMaterialesDG();                   
            }
        grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo del Material que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.eliminarMaterial(txtCodigo.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el Material seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Ese Material no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    throw;
                }
                grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
            }
        grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtCodProv.Text = "";
            txtPrecio.Text = "";
            txtUnidadMedida.Text = "";
            
        }
    }
}
