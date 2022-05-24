using System;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.model;
using System.Windows.Forms;
using CrudTimesCS.view;


namespace CrudTimesCS.controller
{
    class ManipulaTimes
    {
        public void cadastroTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirTimes",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeTimes", Times.NomeTimes);
                cmd.Parameters.AddWithValue("@LogoTimes", Times.LogoTimes);
                cmd.Parameters.AddWithValue("@FraseTimes", Times.FraseTimes);

                SqlParameter nv = cmd.Parameters.Add("@CodTimes", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro efetuado com sucesso, deseja executar um novo cadastro?",
                    "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    Times.Retorno = "Sim";
                    return;
                }
                else
                {
                    Times.Retorno = "Não";
                    return;
                }

            }
            catch(Exception)
            {
                throw;
            }
        }

        public void pesquisarCodigoTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscaCodigoTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", Times.CodTimes);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Times.CodTimes = Convert.ToInt32(arrayDados["CodTimes"]);
                    Times.NomeTimes = arrayDados["NomeTimes"].ToString();
                    Times.FraseTimes = arrayDados["FraseTimes"].ToString();
                    Times.LogoTimes = (System.Array)arrayDados["LogoTimes"];
                    Times.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado","Atenção",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Times.Retorno = "Não";
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Erro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void deletarTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@CodTimes",Times.CodTimes);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Time excluído com sucesso",
                    "Exclução",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Time não pode ser excluído",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", Times.CodTimes);
                cmd.Parameters.AddWithValue("@NomeTimes", Times.NomeTimes);
                cmd.Parameters.AddWithValue("@FraseTimes", Times.FraseTimes);
                cmd.Parameters.AddWithValue("@LogoTimes", Times.LogoTimes);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Time alterado com sucesso","Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("O Time não foi Alterado",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}
