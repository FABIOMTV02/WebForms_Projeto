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
                
                //Criando o comando de pesquisa
                OracleCommand comando = new OracleCommand();
                comando.Connection = ora;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                //Criando adaptador da seleção
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;

            }
            catch (Exception ex)
            {
                this.lblMsgErro.Text = ex.Message;
            }
        }

        protected void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "User Id=ora_tst;Password=ora_tst;Data Source=EGOVD";

                //Abrindo a conexão
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                String sql = "INSERT INTO FABIOTELEFONE(ID, NOME, DDD, TELEFONE, TIPO) " +
                "VALUES(:ID, :NOME, :DDD, :TELEFONE, :TIPO)";
                this.AUD(sql, 0);
            }
            catch (Exception ex)
            {
                this.lblMsgErro.Text = ex.Message;
            }

            
        }

        protected void btn_Apagar_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "User Id=ora_tst;Password=ora_tst;Data Source=EGOVD";

            //Abrindo a conexão
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            //"SELECT COUNT(1) AS total FROM SERVIDOR WHERE DS_CPF = '" + cpf + "' AND DS_APELIDO IS NULL"
            //DELETE FROM FABIOTELEFONE WHERE ID = '22' AND NOME = 'Roger Guedes'
            String sql = "DELETE FROM FABIOTELEFONE WHERE ID = '" + txt_Id.Text + "'";
            this.AUD(sql, 2);
        }

        protected void btn_Alterar_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "User Id=ora_tst;Password=ora_tst;Data Source=EGOVD";

            //Abrindo a conexão
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            //"SELECT COUNT(1) AS total FROM SERVIDOR WHERE DS_CPF = '" + cpf + "' AND DS_APELIDO IS NULL"
            //DELETE FROM FABIOTELEFONE WHERE ID = '22' AND NOME = 'Roger Guedes'
            String sql = "UPDATE FABIOTELEFONE SET NOME = :NOME," +
                "DDD=:DDD, TELEFONE=:TELEFONE " +
                "WHERE ID = :ID";
            this.AUD(sql, 1);
        }

        private void AUD(String sql_stmt, int state)
        {
            String msg = "";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Linha inserida com sucesso!";
                    cmd.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(txt_Id.Text);
                    cmd.Parameters.Add("NOME", OracleDbType.Varchar2, 25).Value = txt_Nome.Text;
                    cmd.Parameters.Add("DDD", OracleDbType.Varchar2, 25).Value = txt_Ddd.Text;
                    cmd.Parameters.Add("TELEFONE", OracleDbType.Varchar2, 25).Value = txt_Tel.Text;
                    cmd.Parameters.Add("TIPO", OracleDbType.Varchar2, 10).Value = DropDownList1_TipoTel.Text;

                    break;
                case 1:
                    msg = "Linha atualizada com sucesso!";
                    cmd.Parameters.Add("NOME", OracleDbType.Varchar2, 25).Value = txt_Nome.Text;
                    cmd.Parameters.Add("DDD", OracleDbType.Varchar2, 25).Value = txt_Ddd.Text;
                    cmd.Parameters.Add("TELEFONE", OracleDbType.Varchar2, 25).Value = txt_Tel.Text;
                    cmd.Parameters.Add("TIPO", OracleDbType.Varchar2, 10).Value = DropDownList1_TipoTel.Text;


                    break;
                case 2:
                    msg = "Linha deletada com sucesso!";

                    cmd.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(txt_Id.Text);

                    break;
            }
            try
            {
                int n = cmd.ExecuteNonQuery();
 
            }
            catch (Exception expe)
            {
                throw expe;
            }
        }

    }
}