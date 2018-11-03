using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WSBD
{
    /// <summary>
    /// Summary description for BD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BD : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //**************************************Conexiona a la DB************************************************************

        SqlConnection conn = new SqlConnection("Data Source=FOXHOUND; Initial Catalog=DBWS; Integrated Security=True;");

        //****************************************Carga de informacion en los Datagridsiews*************************************************
        [WebMethod]
        public DataTable CargarData(string query, string[] parameter, object[] values, string table)
        {
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            if (parameter != null)
                for (var i = 0; i < parameter.Length; i++)
                    cmd.Parameters.AddWithValue(parameter[i], values[i]);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable(table);
            dt.Load(dr);
            dr.Dispose();
            conn.Close();
            return dt;
        }

        //************************************************Pacientes/Clientes/Afiliados/**************************************
        [WebMethod]
        public void AgregarPaciente(int CodPaciente, string Nombre, string FechaNac, int Telefono, string Fechacover, float Monto, string Status)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[Clientes]([CodPaciente],[Nombre],[FechaNac],[Telefono],[Fechacover],[Monto],[Status]) VALUES("+CodPaciente+",'"+Nombre+"','"+FechaNac+"','"+Telefono+"','"+Fechacover+"',"+Monto+",'"+Status+"')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void BorrarPaciente(int CodPaciente)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM [dbo].[Cliente] WHERE CodPaciente = " + CodPaciente + "");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void ActualizaPaciente(int CodPaciente, string Nombre, string FechaNac, int Telefono, string Fechacover, float Monto, string Status)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[Cleintes] SET [CodPaciente] = " + CodPaciente + " ,[Nombre] = '" + Nombre + "',[FechaNac] ='" + FechaNac + "' ,[Telefono] = '" + Telefono + "',[Fechacover] = '" + Fechacover + "',[Monto] =" + Monto + ",[Status] = '" + Status + "' WHERE [CodPaciente] = " + CodPaciente + "");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //**********************************Proveedores/Suppliers********************************************************
        [WebMethod]
        public void AgregarProv(int NIT, string Razonsocial)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[Proveedor] ([NIT],[Razonsocial]) VALUES(" + NIT + ",'" + Razonsocial + "')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void BorrarProv(string NIT)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM [dbo].[Proveedor] WHERE NIT = " + NIT + "");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void ActualizarProv(int NIT, string Razonsocial)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[Proveedor] SET [NIT] = " + NIT + ",[Razonsocial] = '" + Razonsocial + "' WHERE NIT = " + NIT + "");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //************************************************Prima**************************************
        [WebMethod]
        public void AgregarPrim(int NoBoleta, string Fechapagar, int CodPaciente)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[Primas] ([NoBoleta],[Fechapagar],[CodPaciente]) VALUES(" + NoBoleta + ",'" + Fechapagar + "'," + CodPaciente + ")");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
