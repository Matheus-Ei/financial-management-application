using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_de_Gestão_de_Finanças_Pessoais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar a conexão com o banco de dados
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\t4iga\OneDrive\Empresa\Versões do Aplicativo\Aplicativo de Gestão de Finanças Pessoais\database.accdb;";
            OleDbConnection connection = new OleDbConnection(connectionString);

            // Consulta SQL para obter os dados do banco de dados
            string query = "SELECT valor, titulo, data FROM receitas";

            // Criação do comando SQL
            OleDbCommand command = new OleDbCommand(query, connection);

            // Abertura da conexão
            connection.Open();

            // Leitura dos dados do banco de dados
            OleDbDataReader reader = command.ExecuteReader();



            // Adicionar alguns pontos de dados ao gráfico
            chart4.Series.Clear();
            chart4.Series.Add("Dados");
            chart4.Series["Dados"].Points.AddXY("Categoria 1", 10);
            chart4.Series["Dados"].Points.AddXY("Categoria 2", 20);
            chart4.Series["Dados"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart4.Series["Dados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;


            // Limpar os pontos de dados existentes no gráfico
            chart1.Series["dadosReceita"].Points.Clear();
            // Adicionar os pontos de dados do banco de dados ao gráfico
            while (reader.Read())
            {
                string categoria = reader["titulo"].ToString();
                int valor = Convert.ToInt32(reader["valor"]);

                chart1.Series["dadosReceita"].Points.AddXY(categoria, valor);
            }
            // Configurar o tipo de gráfico
            chart2.Series["dadosReceita"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            // Adicionar alguns pontos de dados ao gráfico
            chart1.Series.Clear();
            chart1.Series.Add("dadosDespesas");
            chart1.Series["dadosDespesas"].Points.AddXY("Categoria 1", 10);
            chart1.Series["dadosDespesas"].Points.AddXY("Categoria 2", 20);
            chart1.Series["dadosDespesas"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart1.Series["dadosDespesas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            // Adicionar alguns pontos de dados ao gráfico
            chart3.Series.Clear();
            chart3.Series.Add("dadosPatrimonio");
            chart3.Series["dadosPatrimonio"].Points.AddXY("Categoria 1", 10);
            chart3.Series["dadosPatrimonio"].Points.AddXY("Categoria 2", 20);
            chart3.Series["dadosPatrimonio"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart3.Series["dadosPatrimonio"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void menuLateralClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
