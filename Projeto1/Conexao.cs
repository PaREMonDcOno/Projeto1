using MySql.Data.MySqlClient;
using System;

namespace Projeto1
{

    //Classe - Molde de objetos com seus métodos.
    //Objeto - Tudo que pode ser caracterizado.
    //Método - Ação que um objeto faz.

    class Conexao
    {
        //Instância - Dar apelido.
        //Criando uma instância.
        //Data Source - Caminho.
        //Initial Catalog - Nome do Banco de Dados.

        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjeto;user=root;pwd=12345678");
        public static string msg;
        public MySqlConnection ConnectarBD()
        {

            //Tratamento de erros

            try
            {
                con.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {
            //Tratamento de erros

            try
            {
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se desconectar" + erro.Message;
            }
            return con;
        }

    }
}