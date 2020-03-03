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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string senha;
            string usuario;
            string senhadigitada = senhaCP.Text;
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb";
            cmd.Connection = conn;
            cmd.CommandText = "select * from Login where usuario ='" + loginCP.Text+"'";
            cmd.CommandType = CommandType.Text;

            
            



            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            { senha = dr["senha"].ToString();

                if (senha==senhadigitada)
                {
                    erroCP.Text = "Login Com Sucesso";
                    usuario = dr["usuario"].ToString();
                    if (usuario == "vendedor")
                    {
                        Response.Redirect("Principal.aspx");
                    }
                    else
                    {
                        Response.Redirect("Financeiro.aspx");
                    }
                    


                }
                else
                {
                    erroCP.Text = "senha errada";
                }
            }
            else
            { erroCP.Text = "Login Incorreto ou senha errada"; }
            conn.Close();
            dr.Close();
            conn.Dispose();





        }

        protected void loginCP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}