using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            IsMdiContainer = true;
            Form formclientes = new Clientes();
            formclientes.MdiParent = this;
            formclientes.Show();
        }

        private void registroProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Form formproveedor = new Proveedores();
            formproveedor.MdiParent = this;
            formproveedor.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pagosPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Form formprimas = new PagoPrima();
            formprimas.MdiParent = this;
            formprimas.Show();
        }
    }
}
