using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPonto4
{
    public partial class Entrada : Form
    {
        private MySqlConnection conexao = GerenciadorConexao.ObterConexao();
        MySqlDataAdapter adaptador;
        MySqlCommandBuilder construtor;


        public Entrada()
        {
            InitializeComponent();


        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens (*.jpg, *.png)|*.jpg;*.png|Todos os arquivos (*.*)|*.*";
            openFileDialog.Title = "Selecione a imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFoto.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception erro)
                {
                    MessageBox.Show($"Ocorreu um erro:{erro.Message}");
                }
            }
        }

        private void InserirRegistro()
        {

            //Abre a Conexão
            GerenciadorConexao.AbrirConexao(conexao);

            //verifica os dados do ID digitado pelo usuário
            var verificarID = new MySqlCommand($"SELECT id, nome FROM usuario WHERE id = {txtId.Text}", conexao);

            //Datareader irá armazenar os dados do select na aplicação
            MySqlDataReader reader = verificarID.ExecuteReader();

            //verifica se há informações armazenadas no DataReader

            try
            {
                if (reader.Read())
                {
                    //Lê os campos resgatados do SELECT(id e nome)
                    Usuario usuario = new Usuario(reader.GetInt32("id"), reader.GetString("nome"));

                    Registro registro = new Registro();

                    //Resgata Diretório do projeto em desenvolvimento
                    string diretorioProjeto = AppDomain.CurrentDomain.BaseDirectory;

                    string diretorioImg = "Fotos";

                    //Resgata nome do usuário da máquina atual
                    string diretorioUser = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;

                    //Resgata data e hora atual
                    registro.DataHora = DateTime.Now;

                    string DataFormatada = registro.DataHora.ToString();

                    //Formatar Data para ser aceita como nome do arquivo
                    DataFormatada = DataFormatada.Replace('/', '_');
                    DataFormatada = DataFormatada.Replace(':', '_');

                    //Define qual diretório cada usuário irá salvar suas fotos
                    string path = diretorioProjeto + "\\" + diretorioImg + "\\" + usuario.Nome;

                    //Define nome do Arquivo salvo no diretório como "Id + Nome + Data e Hora.jpg"
                    registro.Foto = path + "\\" + usuario.Id + " " + usuario.Nome + " " + DataFormatada + ".jpg";

                    bool diretorioExiste = Directory.Exists(path);

                    //Verifica se o diretório do usuário existe
                    if (!diretorioExiste)
                    {
                        Directory.CreateDirectory(path);
                    }

                    //Salva imagem no diretório designado anteriormente
                    pbFoto.Image.Save(registro.Foto);

                    GerenciadorConexao.FecharConexao(conexao);


                    GerenciadorConexao.AbrirConexao(conexao);

                    //Insere o registro no Banco de dados
                    string sql = $"INSERT INTO registro (idUsuario, foto, datahora) VALUES (@id, @foto, @dateTimeNow)";

                    var command = new MySqlCommand(sql, conexao);

                    command.Parameters.AddWithValue("@id", usuario.Id);
                    command.Parameters.AddWithValue("@foto", registro.Foto);
                    command.Parameters.AddWithValue("@dateTimeNow", registro.DataHora);

                    command.ExecuteNonQuery();
                    MessageBox.Show($"{usuario.Nome} seu registro foi efetuado com sucesso! data e hora do registro: {registro.DataHora}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Id {txtId.Text} de usuário inexistente no banco de dados", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message); ;
            }

            GerenciadorConexao.FecharConexao(conexao);

        }
        private void PopularDataGrid(int? idUsuario = null)
        {
            DataTable tabela;
            tabela = new DataTable();
            dgRegistros.DataSource = tabela;

            //verifica se o Id do usuário não está vazio
            if (idUsuario != null)
            {
                //Consulta SQL para dar um SELECT com inner join na tabela registro e associar o id do usuario da tabela registro com o nome da tabela usuario através do Id do usuario
                string sql = $"SELECT idUsuario, usuario.nome, foto, datahora FROM registro INNER JOIN usuario ON registro.IdUsuario = usuario.id WHERE registro.idUsuario = {idUsuario}";

                //comando para criar o adaptador e o contrutor SQL
                adaptador = new MySqlDataAdapter(sql, conexao);
                construtor = new MySqlCommandBuilder(adaptador);

                //Preenche a Datatable com os dados do banco de dados
                tabela = new DataTable();
                adaptador.Fill(tabela);

                dgRegistros.DataSource = tabela;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Insira seu ID para efetuar o registro!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (pbFoto.Image == null)
                {
                    MessageBox.Show("insira uma foto para efetuar o registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GerenciadorConexao.AbrirConexao(conexao);
                    InserirRegistro();
                    PopularDataGrid(Convert.ToInt32(txtId.Text));
                    GerenciadorConexao.FecharConexao(conexao);
                }
            }


        }
    }
}
