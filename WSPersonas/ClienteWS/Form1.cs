using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var contrato = txtContrato.Text;

            using (WSPersonas.WSPersonasClient client = new WSPersonas.WSPersonasClient())
            {
                var persona = client.ObtenerPersona(contrato);
                var nombre = persona.Nombre;

                
            }
        }
    }
}
