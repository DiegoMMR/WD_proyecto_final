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
        //**************************************Conexiona DB************************************************************

        SqlConnection conn = new SqlConnection("Data Source=FOXHOUND; Initial Catalog=DBWS; Integrated Security=True;");

        //****************************************Carga de Datagridsiews*************************************************
        [WebMethod]
        public DataTable LoadData(string query, string[] parameter, object[] values, string table)
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

        //************************************************Afiliados******************************************************
        [WebMethod]
        public void ADDAfiliado(int CodPaciente, string Nombre, string FechaNac, int Telefono, string Fechacover, float Monto, string Status)
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
        public void DELAfiliado(int CodPaciente)
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
        public void Actualiza_Afiliado(int CodPaciente, string Nombre, string FechaNac, int Telefono, string Fechacover, float Monto, string Status)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[Cleintes] SET [CodPaciente] = " + CodPaciente + " ,[Nombre] = '" + Nombre + "',[FechaNac] ='" + FechaNac + "' ,[Telefono] = '" + Telefono + "',[Fechacover] = '" + Fechacover + "',[Monto] =" + Monto + ",[Status] = '" + Status + "' WHERE [CodPaciente] = " + CodPaciente + "");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
