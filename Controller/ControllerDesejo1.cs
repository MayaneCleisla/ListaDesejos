using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerDesejo1
    {
        public bool GravarDesejo(Desejo desejo)
        {
            SqlConnetion conexao = ADODBConnection.Connection();

            SqlCommand comando = conexao.CreateCommand();

            if (desejo.IDDesejo == 0)
            {
                comando.CommandText = "insert into tbl_desejo (solicitante, solicitado, valor, dataDesejo, descricao) values(@solicitante, @solicitado, @valor, @dataDesejo, @descricao)";
                comando.Parameters.AddWithValue("@solicitante", desejo.Solicitante);
                comando.Parameters.AddWithValue("@solicitado", desejo.Solicitado);
                comando.Parameters.AddWithValue("@valor", desejo.Valor);
                comando.Parameters.AddWithValue("@dataDesejo", desejo.DataDesejo);
                comando.Parameters.AddWithValue("@descricao", desejo.Descricao);
            }

            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;

        }

        public bool ListarDesejosPorAmigo(int idAmigo)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_desejo order by nome where id_desejo=@iddesejo";
            comando.Parameters.AddWithValue("@iddesejo", idDesejo);
            Desejo desejo = null;
            conexao.Open();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                if (reader.Read())
                {
                    desejo = new Desejo();
                    desejo.IDDesejo = reader.GetInt32(0);
                    desejo.Solicitante = reader.GetString(1);
                    desejo.Solicitado = reader.GetString(2);
                    desejo.Valor = reader.GetDateTime(3);
                    desejo.DataDesejo = reader.GetDateTime(4);
                    desejo.Descricao = reader.GetDateTime(5);

                }
                conexao.Close();
            }
            return desejo;
        }

    }
}
