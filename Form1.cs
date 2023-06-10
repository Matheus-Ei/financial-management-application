using System;
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
            // Adicionar alguns pontos de dados ao gráfico
            chart4.Series.Clear();
            chart4.Series.Add("Dados");
            chart4.Series["Dados"].Points.AddXY("Categoria 1", 10);
            chart4.Series["Dados"].Points.AddXY("Categoria 2", 20);
            chart4.Series["Dados"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart4.Series["Dados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;


            // Adicionar alguns pontos de dados ao gráfico
            chart2.Series.Clear();
            chart2.Series.Add("dadosReceita");
            chart2.Series["dadosReceita"].Points.AddXY("Categoria 1", 10);
            chart2.Series["dadosReceita"].Points.AddXY("Categoria 2", 20);
            chart2.Series["dadosReceita"].Points.AddXY("Categoria 3", 15);
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


            // Adicionar alguns pontos de dados ao gráfico
            chart5.Series.Clear();
            chart5.Series.Add("dadosBalanco");
            chart5.Series["dadosBalanco"].Points.AddXY("Categoria 1", 10);
            chart5.Series["dadosBalanco"].Points.AddXY("Categoria 2", 20);
            chart5.Series["dadosBalanco"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart5.Series["dadosBalanco"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            // Adicionar alguns pontos de dados ao gráfico
            chart8.Series.Clear();
            chart8.Series.Add("dadosCarteira");
            chart8.Series["dadosCarteira"].Points.AddXY("Categoria 1", 10);
            chart8.Series["dadosCarteira"].Points.AddXY("Categoria 2", 20);
            chart8.Series["dadosCarteira"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart8.Series["dadosCarteira"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            // Adicionar alguns pontos de dados ao gráfico
            chart7.Series.Clear();
            chart7.Series.Add("dadosRendimentos");
            chart7.Series["dadosRendimentos"].Points.AddXY("Categoria 1", 10);
            chart7.Series["dadosRendimentos"].Points.AddXY("Categoria 2", 20);
            chart7.Series["dadosRendimentos"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart7.Series["dadosRendimentos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            // Adicionar alguns pontos de dados ao gráfico
            chart6.Series.Clear();
            chart6.Series.Add("dadosProporcao");
            chart6.Series["dadosProporcao"].Points.AddXY("Categoria 1", 10);
            chart6.Series["dadosProporcao"].Points.AddXY("Categoria 2", 20);
            chart6.Series["dadosProporcao"].Points.AddXY("Categoria 3", 15);
            // Configurar o tipo de gráfico
            chart6.Series["dadosProporcao"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void menuLateralClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
