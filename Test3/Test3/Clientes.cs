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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtpaciente.Clear();
            txtmonto.Clear();
            txttelefono.Clear();
            txtnombre.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtcodpaciente.Clear();
            txtfullname.Clear();
            txtmontocovertura.Clear();
            txttel.Clear();
            txtstatus.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
