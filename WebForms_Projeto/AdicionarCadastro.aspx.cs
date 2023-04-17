using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Projeto
{
    public partial class AdicionarCadastro : System.Web.UI.Page
    {
        OracleConnection con = new OracleConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Adicionar_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO FABIOTELEFONE(ID, NOME, DDD, TELEFONE, TIPO) " +
                "VALUES(:ID, :NOME, :DDD, :TELEFONE, :TIPO)";
            this.AUD(sql, 0);
        }

        protected void btn_Apagar_Click(object sender, EventArgs e)
        {

        }

        private void AUD(String sql_stmt, int state)
        {
            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Linha inseida com sucesso!";
                    cmd.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(txt_Id.Text);
                    cmd.Parameters.Add("NOME", OracleDbType.Varchar2, 25).Value = txt_Nome.Text;
                    cmd.Parameters.Add("DDD", OracleDbType.Varchar2, 25).Value = txt_Ddd.Text;
                    cmd.Parameters.Add("TELEFONE", OracleDbType.Varchar2, 25).Value = txt_Tel.Text;
                    cmd.Parameters.Add("TIPO", OracleDbType.Varchar2, 10).Value = txt_Tipo.Text;

                    break;
                case 1:
                    //msg = "Row Updated Successfully!";
                    //cmd.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 25).Value = last_name_txtbx.Text;
                    //cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 25).Value = email_txtbx.Text;
                    //cmd.Parameters.Add("HIRE_DATE", OracleDbType.Date, 7).Value = hire_date_picker.SelectedDate;

                    //cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(employee_id_txtbx.Text);

                    break;
                case 2:
                    //msg = "Row Deleted Successfully!";

                    //cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(employee_id_txtbx.Text);

                    break;
            }
            try
            {
                int n = cmd.ExecuteNonQuery();
 
            }
            catch (Exception expe) { }
        }
    }
}