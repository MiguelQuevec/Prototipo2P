using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados b = new Empleados();
            b.MdiParent = this;
            b.Show();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrato b = new Contrato();
            b.MdiParent = this;
            b.Show();
        }
    }
}
