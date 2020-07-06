using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PALUNO
{
    class Aluno
    {
        private int raaluno;
        private string nomealuno;
        private int cidadeidcidade;

        public int Raaluno
        {
            get
            {
                return raaluno;
            }
            set
            {
                raaluno = value;
            }
        }


        public string Nomealuno
        {
            get
            {
                return nomealuno;
            }
            set
            {
                nomealuno = value;
            }
        }



        public int Cidadeidcidade
        {
            get
            {
                return cidadeidcidade;
            }
            set
            {
                cidadeidcidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daAluno;

            DataTable dtAluno = new DataTable();

            try
            {
                daAluno = new SqlDataAdapter("SELECT * FROM TBALUNO", frmPrincipal.conexao);
                daAluno.Fill(dtAluno);
                daAluno.FillSchema(dtAluno, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAluno;
        }

        public int Salvar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TBALUNO VALUES (@RA_ALUNO,@NOME_ALUNO,@CIDADE_ID_CIDADE)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@RA_ALUNO", SqlDbType.Int)); ;
                mycommand.Parameters.Add(new SqlParameter("@NOME_ALUNO", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@CIDADE_ID_CIDADE", SqlDbType.Int));

                mycommand.Parameters["@RA_ALUNO"].Value = raaluno;
                mycommand.Parameters["@NOME_ALUNO"].Value = nomealuno;
                mycommand.Parameters["@CIDADE_ID_CIDADE"].Value = cidadeidcidade;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBALUNO SET NOME_ALUNO = @NOME_ALUNO ,CIDADE_ID_CIDADE = @CIDADE_ID_CIDADE WHERE RA_ALUNO = @RA_ALUNO", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@RA_ALUNO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NOME_ALUNO", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@CIDADE_ID_CIDADE", SqlDbType.Int));

                mycommand.Parameters["@RA_ALUNO"].Value = raaluno;
                mycommand.Parameters["@NOME_ALUNO"].Value = nomealuno;
                mycommand.Parameters["@CIDADE_ID_CIDADE"].Value = cidadeidcidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }


        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM TBALUNO WHERE ra_aluno=@RA_ALUNO", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@RA_ALUNO", SqlDbType.Int));
                mycommand.Parameters["@RA_ALUNO"].Value = Convert.ToInt32(raaluno);

                nReg = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }


    }
}
