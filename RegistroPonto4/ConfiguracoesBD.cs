using MySql.Data.MySqlClient;
using System.Data;

public static class GerenciadorConexao
{
    private static string stringConexao = "server=localhost;uid=root;pwd=admin;database=empresa";

    public static MySqlConnection ObterConexao()
    {
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        return conexao;
    }

    public static void AbrirConexao(MySqlConnection conexao)
    {
        if (conexao != null && conexao.State != ConnectionState.Open)
        {
            conexao.Open();
        }
    }

    public static void FecharConexao(MySqlConnection conexao)
    {

        conexao.Close();

    }


}