using System;
using System.Windows.Forms;
using TimeControl.Model;


namespace TimeControl.View
{
    public partial class Responsabilidades : Form
    {
        public Responsabilidades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Classe        //objeto    //Chamada ao construtor
#region inserir_banco_de_dados
            ResponsabilidadesVO r = new ResponsabilidadesVO();
            //operador de instânciação -criar um novo objeto
            r.Descricao = textBox1.Text;
            ResponsabilidadeDAO rdao = new ResponsabilidadeDAO();
            rdao.InserirResponsabilidade(Conexao.Instance, r);
            textBox1.Text = "";
            CarregarResponsabilidades();
#endregion


            // MessageBox.Show(r.Descricao);
            /*
                        ResponsabilidadesVO r2 = new ResponsabilidadesVO();
                        r2.Descricao = "Desenvolvimento Pessoal";
                        MessageBox.Show(r2.Descricao);

                        ResponsabilidadesVO r3 = new ResponsabilidadesVO();
                        r3.Descricao = "Gestão de Pessoas";
                        MessageBox.Show(r3.Descricao);

                        MessageBox.Show($"total de objetos:{ResponsabilidadesVO.RetornaContador()}");
                        DetalhesConexao d = new DetalhesConexao(Conexao.Instance);
                        MessageBox.Show(d.ConexaoString);

            */
            DetalhesConexao d = new DetalhesConexao(Conexao.Instance);
            MessageBox.Show(d.ConexaoString);
            var dado = d.ConexaoString;
            int posicaoAtual;

            string[] vetorConexao = new string[4];
            for (int i = 0; i < 4; i++)
            {
              //  vetorConexao[i] = 

            }
            string frase = "jovem1;jovem2;jovem3;jovem4;jovem5;jovem6";
            string[] palavras = frase.Split(';');

            foreach (var palavra in palavras)
            {
                MessageBox.Show($"olá tudo esse é: {palavra} não disse que é isso");
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para excluir
            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var descricao = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show(id);
            MessageBox.Show(descricao);
        }

        private void Responsabilidades_Load(object sender, EventArgs e)
        {
            CarregarResponsabilidades();
        }
        private void CarregarResponsabilidades()
        {
            ResponsabilidadeDAO rdao = new ResponsabilidadeDAO();

            dataGridView1.DataSource = rdao.ListarResponsabilidades(Conexao.Instance);



        }
    }
}
