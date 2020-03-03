using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleVendasAspNetReal
{
    public partial class Financeiro : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            readtable();
        }
        public void readtable()
        {


            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb";
            cmd.Connection = conn;
            cmd.CommandText = "select * from controle";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            dr = cmd.ExecuteReader();
            DataTable clientes = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            clientes.Load(dr);
            GridView2.DataSource = clientes;
            GridView2.DataBind();

        }
    }
}