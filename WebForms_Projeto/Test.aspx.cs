using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;


namespace WebForms_Projeto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection ora = new OracleConnection();
                ora.ConnectionString = "User Id=bdip;Password=bdidesenv;Data Source=EGOVD";

                if (ora.State != System.Data.ConnectionState.Open)
                {
                    ora.Open();
                }

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

    }
}