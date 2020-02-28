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
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void incluir_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(); OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb"; cmd.Connection = conn;
            cmd.CommandText = "Select * from controle where nome ='" + nomeCP.Text+"'"; cmd.CommandType = System.Data.CommandType.Text; conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {erro2CP.Text = "Código já incluído"; }
            else
            {
                conn.Close();

            }
            cmd.CommandText = "insert into controle (nome,quantidade,valor) values ('" + nomeCP.Text + "', " + quantCP.Text + ","+valorCP.Text+")";
            cmd.CommandType = CommandType.Text; conn.Open(); cmd.ExecuteScalar();
            erro2CP.Text = " Registro incluido com sucesso";
            conn.Close(); conn.Dispose();
        }
        

        }
}