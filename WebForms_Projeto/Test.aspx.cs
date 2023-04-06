using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
// using Oracle.ManagedDataAccess.Client;
using System.Data.OracleClient;

using System.Data;

namespace WebForms_Projeto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            dlSite.Items.Add(txtSite.Text); 
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection();
            ora.ConnectionString = "User Id=ora_tst;Password=ora_tst;Data Source=EGOVD";

            if (ora.State != System.Data.ConnectionState.Open)
            {
                ora.Open();
            }

            ora.Open();
            OracleCommand comando = new OracleCommand("gridtelefones", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("FABIOTELEFONE",OracleType.Cursor).Direction=ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            gvOracle.DataSource = dt;

            ora.Close();
            
        }
    }
}