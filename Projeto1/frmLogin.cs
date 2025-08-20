using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmLogin : Form
    {

        //Instanciando a String de Conexão
        Conexao con = new Conexao();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show ("Usuário e senha inválidos");
            }

            try
            {

                //Indica o que vai procurar

                String sql = "select * from tbLogin where usuario=@user and senha=@senha";

                //Indica que ele sabe o que vai procurar e tem poder para fazer uma ação

                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());

                //Atribui valor do C# ao MySql

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;

                //Instancia dados para que ele leia o que estiver no Banco de Dados

                MySqlDataReader dados;
                dados = cmd.ExecuteReader();

                //Se houver linhas, será lida, e entrará no Banco de Dados

                if (dados.HasRows)
                {
                    MessageBox.Show("Seja bem-vindo ao sistema");
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.Show();
                }

                //Irá voltar e limpar os campos

                else
                {
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }

            //Mostra um erro

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //Fecha a porta para o Banco de Dados

            finally
            {
                con.DesConnectarBD();
            }
        }
    }
}