using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Test3.WScarga;

namespace Test3
{
    public partial class Clientes : Form
    {
        WScarga.DBSoapClient ws = new WScarga.DBSoapClient();
        string EliminarPaciente;
        string ModificarPaciente;

        //Datos obtenidos de datagridview
        int valor1;
        string valor2;
        DateTime valor3;
        int valor4;
        DateTime valor5;
        float valor6;
        string valor7;
        DateTime valor8;
        DateTime valor9;

        DataGridViewRow row;

        public object Response { get; private set; }

        public void RegistroSeleccionado()
        {
            //por el numero obtiene la columna
            valor1 = int.Parse(row.Cells[0].Value.ToString());
            valor2 = row.Cells[1].Value.ToString();
            valor3 = DateTime.Parse(row.Cells[2].Value.ToString());
            valor4 = int.Parse(row.Cells[3].Value.ToString());
            string valida = row.Cells[4].Value.ToString();
            if (valida != "")
            {
                valor5 = DateTime.Parse(row.Cells[4].Value.ToString());
            }
            else
            {
                valor5 = DateTime.Now.Date;
            }
            string valida2 = row.Cells[5].Value.ToString();
            if (valida != "")
            {
                valor8 = DateTime.Parse(row.Cells[5].Value.ToString());
            }
            else
            {
                valor9 = DateTime.Now.Date;
            }

            valor6 = float.Parse(row.Cells[6].Value.ToString());
            valor7 = row.Cells[7].Value.ToString();
        }
        public void BuscarCliente()
        {
            if (string.IsNullOrEmpty(text_busqueda.Text))
            {
                MessageBox.Show("Debe ingresar el Codigo del Cliente-Paciente-Afiliado");
            }
            else
            {
                string BusqId = this.text_busqueda.Text;
                EliminarPaciente = BusqId;
                dataGridView1.DataSource = ws.CargarData("SELECT * FROM [dbo].[Clientes] WHERE CodPaciente = " + BusqId + "", null, null, "Clientes");

                try
                {
                    dataGridView1.Rows[0].Selected = true;
                    row = dataGridView1.Rows[0];
                    RegistroSeleccionado();
                }
                catch (Exception error)
                {
                    MessageBox.Show("El registro No existe");
                    Console.WriteLine(error);
                }

                EliminarPaciente = valor1.ToString();
            }

        }
        public void Boton_modificar()
        {
            txtpaciente.Text = valor1.ToString();
            txtnombre.Text = valor2;
            fechanaci.Value = valor3;
            txttelefono.Text = valor4.ToString();
            fechacov.Value = valor5;
            txtmonto.Text = valor7.ToString();

        }


        public void AgregarPaciente()
        {

            try
            {
                int AgregarCodPaciente;
                String AgregarNombre;
                String AgregarFechaNac;
                int AgregarTel;
                String AgregarFechaCov;
                float monto = 0;
                String Status;

                if (string.IsNullOrEmpty(txtcodpaciente.Text) || string.IsNullOrEmpty(txtfullname.Text) || string.IsNullOrEmpty(txttel.Text) || string.IsNullOrEmpty(txtmontocovertura.Text) || string.IsNullOrEmpty(txtstatus.Text))
                {
                    MessageBox.Show("Debe completar la informacion");
                }
                else
                {
                    AgregarCodPaciente = int.Parse(txtcodpaciente.Text);
                    AgregarNombre = this.txtfullname.Text;
                    AgregarFechaNac = this.fechanac.Text;
                    AgregarTel = int.Parse(txttel.Text);
                    AgregarFechaCov = this.fechacover.Text;
                    monto = float.Parse(this.txtmontocovertura.Text);
                    Status = this.txtstatus.Text;

                    ws.AgregarPaciente(AgregarCodPaciente, AgregarNombre, AgregarFechaNac, AgregarTel, AgregarFechaCov, monto, Status);
                    dataGridView1.DataSource = ws.CargarData("SELECT * FROM [dbo].[Clientes] ");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("OPPS... XP : " + error);
            }
        }

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

        private void txtmontocovertura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
