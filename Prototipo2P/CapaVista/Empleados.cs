using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Empleados : Form
    {
        string table = "tbl_empleados";
        Controlador cn = new Controlador();

        public Empleados()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtIDcontrato.Text = "";
            txtpuesto.Text = "";
        }

        public void Actualizar()
        {
            DataTable dt = cn.llenarTbl(table);
            listEmpleados.DataSource = dt;
            // string idUsuario = txtIDempleado.Text;
            // cn.llenarListApliUsuariosstring(listEmpleados.Tag.ToString(), listEmpleados, idUsuario);
        }

        public void IngresarData()
        {
            DataTable dt = cn.llenarTbl(table);
            listEmpleados.DataSource = dt;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtBusacar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = {txtNombre, txtIDcontrato, txtpuesto};
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            Actualizar();
            limpiar();
            MessageBox.Show(message);
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            txtEliminar.Visible = false;
            IngresarData();
        }

        private void listMaestro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = listEmpleados.CurrentCell.Value.ToString();
                txtEliminar.Text = dato;


                string message = "Deseas Eliminar el Registro?";
                string title = "Eliminar Registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //int campo = int.Parse(txtBusacar.Text);
                    string condicion = "IDempleado = ";
                    cn.eliminar(table, condicion, Int32.Parse(dato));
                    IngresarData();
                    //this.Close();
                }
                else
                {
                    limpiar();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {          
            TextBox[] textbox = {txtNombre, txtIDcontrato, txtpuesto};
            int valor1 = int.Parse(txtBusacar.Text);
            string campo = "IDempleado = ";
            cn.actualizar(textbox, table, campo, valor1);
            IngresarData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
