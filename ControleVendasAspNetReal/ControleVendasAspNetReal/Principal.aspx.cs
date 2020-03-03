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
            GridView1.DataSource = clientes;
            GridView1.DataBind();
           
           
            

            //.Columns(3).DefaultCellStyle.Format = "C2";
            //string nome = "DEU CERTO!!";
            // tabelavendas.InnerHtml = $"<h1>{nome}</h1>";
        }

        protected void incluir_btn_Click(object sender, EventArgs e)
        {
            Inserirnobanco();
        }
        protected void alterar_btn_Click(object sender, EventArgs e)
        {
            AlteraBanco();
            readtable();

        }
        protected void pesquisar_btn_Click(object sender, EventArgs e)
        {
            ConsultaBanco();

        }


        private void Inserirnobanco()
        {
            OleDbConnection conn = new OleDbConnection(); OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb"; cmd.Connection = conn;
            cmd.CommandText = "Select * from controle where nome ='" + nomeCP.Text + "'"; cmd.CommandType = System.Data.CommandType.Text;
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            
                conn.Close();
                conn.Open();
                cmd.CommandText = "insert into controle (nome,quantidade,valor) values ('" + nomeCP.Text + "', " + quantCP.Text + "," + valorCP.Text + ")";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                erro2CP.Text = " Registro incluido com sucesso";
                conn.Close();
                conn.Dispose();
                readtable();
           
            
        }

        
        private void AlteraBanco()
        {
            OleDbConnection conn = new OleDbConnection(); OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb"; cmd.Connection = conn;
            cmd.CommandText = "update controle set nome='" + nomeCP.Text + "',quantidade=" + quantCP.Text + ",valor=" + valorCP.Text + " where Código=" + codCP.Text;
            cmd.CommandType = CommandType.Text;
            conn.Open(); cmd.ExecuteNonQuery(); conn.Close(); conn.Dispose();
        }

        protected void excluir_btn_Click(object sender, EventArgs e)
        {
            Excluidobanco();
            readtable();
        }

        private void Excluidobanco()
        {
            OleDbConnection conn = new OleDbConnection(); OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb"; cmd.Connection = conn;
            cmd.CommandText = "delete from controle where Código=" + codCP.Text;
            cmd.CommandType = CommandType.Text;
            conn.Open(); cmd.ExecuteNonQuery(); conn.Close(); conn.Dispose();
        }

        

        private void ConsultaBanco()
        {
            
            OleDbConnection conn = new OleDbConnection(); OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\BancoAspNet\\ControleVendas.mdb"; cmd.Connection = conn;
            cmd.CommandText = "select * from controle where Código=" + codCP.Text;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nomeCP.Text = dr["nome"].ToString();
                quantCP.Text = dr["quantidade"].ToString();
                valorCP.Text = dr["valor"].ToString();
                
            }
            else
            {
                erro2CP.Text = "Registro  não encontrado";
            }
            conn.Close(); dr.Close(); conn.Dispose();
        }
    }
}