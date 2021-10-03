using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Loja
{
    public partial class FormEstoque : Form
    {
        int qtdtotal, qtd = 0;
        Decimal valortotal, valor = 0;

        //Inicializa as variaveis para Quantidade total em estoque e Valor total em estoque.
        //Não pertencem ao grid.

        public FormEstoque()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {

            //Cria conexão com o banco, passando os dados.

            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "loja";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        private void FormEstoque_Load(object sender, EventArgs e)
        {            
            atualizaGrid();
        }
        private void atualizaGrid()
        {

            //Função para atualizar o grid.

            qtdtotal = 0;
            valortotal = 0;
            tbValorTotal.Text = "";
            tbQtdTotal.Text = "";

            //Zera os valores de Quantidade total e Valor total.

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM estoque";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgEstoque.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgEstoque.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    dgEstoque.Rows.Add(row);

                    //Calcula novamente os valores de Quantidade total e Valor total, após atualizar grid.

                    qtd = Convert.ToInt32(row.Cells[4].Value);
                    qtdtotal = qtdtotal + qtd;
                    tbQtdTotal.Text = Convert.ToString(qtdtotal);
                    valor = Convert.ToDecimal(row.Cells[3].Value);
                    valortotal = valortotal + (valor * qtd);
                    tbValorTotal.Text = "R$ " + Convert.ToString(valortotal);
                    
                    
                }
                

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            //Código executado ao clicar em incluir novo item no estoque.

            if (tbMarca.Text != "" && tbDescricao.Text!="" && tbValor.Text != "" && tbQtd.Text != "")

                //Verifica existencia de campos em branco. 
            {
                Decimal total = Convert.ToDecimal(tbValor.Text) * Convert.ToDecimal(tbQtd.Text);

                //Insere quantidade na variavel total.
                //Conecta com banco.
               
                
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexaoBD.Open();

                    MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();

                    comandoMySql.CommandText = "INSERT INTO estoque (marca,descricao, valor, qtd, total) " +
                        "VALUES('" + tbMarca.Text + "', '" + tbDescricao.Text + "', '" + tbValor.Text + "', '" + tbQtd.Text + "', '" + total + "')";
                    
                    comandoMySql.ExecuteNonQuery();

                    realizaConexaoBD.Close();
                    MessageBox.Show("Inserido com sucesso");

                    //Chama função atualiza grid e limpar campos.

                    atualizaGrid();
                    limparCampos();

                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserir dados");

                //Se existia campos em branco, apresenta a mensagem "Inserir dados".

            }
        }
        private void limparCampos()
        {
            tbMarca.Clear();
            tbDescricao.Clear();
            tbCodigo.Clear();
            tbValor.Clear();
            tbQtd.Clear();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Código executado ao clicar em Excluir item no estoque.

            if (tbCodigo.Text != "")
            {
                //Verifica se existe uma linha selecionada para exclusão através do campo código.
                //Conecta com banco.

                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexaoBD.Open();

                    MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();

                    comandoMySql.CommandText = "DELETE FROM estoque WHERE codigo = " + dgEstoque.CurrentRow.Cells[0].Value;
                    comandoMySql.ExecuteNonQuery();

                    realizaConexaoBD.Close();
                    MessageBox.Show("Excluido com sucesso");

                    //Chama função atualiza grid e limpar campos.

                    atualizaGrid();
                    limparCampos();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione um item");

                //Se não tinha linha selecionada, exibe a mensagem "Selecione um item".

            }

        }

        private void dgEstoque_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEstoque.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgEstoque.CurrentRow.Selected = true;

                //preenche os textbox com as células da linha selecionada

                tbCodigo.Text = dgEstoque.Rows[e.RowIndex].Cells["ColCodigo"].FormattedValue.ToString();
                tbMarca.Text = dgEstoque.Rows[e.RowIndex].Cells["ColMarca"].FormattedValue.ToString();
                tbDescricao.Text = dgEstoque.Rows[e.RowIndex].Cells["ColDescricao"].FormattedValue.ToString();
                tbValor.Text = dgEstoque.Rows[e.RowIndex].Cells["ColValor"].FormattedValue.ToString();
                tbQtd.Text = dgEstoque.Rows[e.RowIndex].Cells["ColQtd"].FormattedValue.ToString();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Código executado ao clicar em Alterar item no estoque.

            if (tbMarca.Text != "" && tbDescricao.Text != "" && tbValor.Text != "" && tbQtd.Text != "")
            {
                //Verifica existencia de campos em branco.
                
                decimal total = Convert.ToDecimal(tbValor.Text) * Convert.ToDecimal(tbQtd.Text);

                //Insere quantidade na variavel total.
                //Conecta com o banco.

                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexaoBD.Open();

                    MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();

                    comandoMySql.CommandText = "UPDATE estoque SET marca = '" + tbMarca.Text + "', descricao = '" + tbDescricao.Text + "', valor = '" + tbValor.Text + "', qtd = '" + tbQtd.Text + "', total = '" + total + "' WHERE codigo = " + dgEstoque.CurrentRow.Cells[0].Value;
                    comandoMySql.ExecuteNonQuery();

                    realizaConexaoBD.Close();
                    MessageBox.Show("Alterado com sucesso");

                    //Chama função atualiza grid e limpar campos.

                    atualizaGrid();
                    limparCampos();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserir dados");

                //Se existia campos em branco, apresenta a mensagem "Inserir dados".

            }
            
            
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

