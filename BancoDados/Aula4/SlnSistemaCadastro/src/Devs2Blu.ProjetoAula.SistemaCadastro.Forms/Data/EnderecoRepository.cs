/*using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetoAula.SistemaCadastro.Forms.Data
{
    public class EnderecoRepository
    {
        public Endereco Save(Endereco endereco)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                endereco.Pessoa.Id = SavePessoa(endereco, conn);

                return endereco;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SavePessoa(Endereco endereco, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = endereco.Pessoa.Nome;
                cmd.Parameters.Add("cgccpg", MySqlDbType.VarChar, 25).Value = endereco.Pessoa.CGCCPF;
                cmd.Parameters.Add("tipopessoa", MySqlDbType.Enum).Value = endereco.Pessoa.TipoPessoa;
                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOAS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLS
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
(nome,
cgccpf,
tipopessoa,
flstatus)
VALUES
(@nome,
@cgccpf,
@tipopessoa,
'A')";
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
(id_pessoa,
CEP,
rua,
numero,
bairro,
cidade,
uf)
VALUES
(@idPessoa,
@CEP,
@rua,
@numero,
@bairro,
@cidade,
@uf)";
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
(id_pessoa,
id_convenio,
numero_prontuario,
endereco_risco,
flstatus,
flobito)
VALUES
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@endereco_risco,
'A',
0)";
        private const String SQL_SELECT_PESSOAS = @"SELECT id, nome, cgccpf, flstatus from pessoa";
        #endregion
    }
}*/