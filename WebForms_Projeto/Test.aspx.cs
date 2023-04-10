using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Text;

namespace WebForms_Projeto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection();
            try
            {
                DataTable dt = new DataTable();

                ora.ConnectionString = "User Id=ora_tst;Password=ora_tst;Data Source=EGOVD";

                //Abrindo a conexão
                if (ora.State != System.Data.ConnectionState.Open)
                {
                    ora.Open();
                }

                //SQL
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM FABIOTELEFONE FULL JOIN TIPOTEL ON FABIOTELEFONE.ID_tipo = TIPOTEL.ID");

                //Criando o comando de pesquisa
                OracleCommand comando = new OracleCommand();
                comando.Connection = ora;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                //Criando adaptador da seleção
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;

                adaptador.Fill(dt);
                gvOracle.DataSource = dt;
                gvOracle.DataBind();
            }
            catch (Exception ex)
            {
                this.lblErroMsg.Text = ex.Message;
            }
            finally
            {
                ora.Close();
            }

        }

        

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            dlSite.Items.Add(txtSite.Text); 
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}