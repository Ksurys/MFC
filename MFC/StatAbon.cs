using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace MFC
{
    public partial class StatAbon : Form
    {
        public StatAbon()
        {
            InitializeComponent();
        }
        
        private void StatAbon_Load(object sender, EventArgs e)
        {
            
            //chart1.Series.Clear();
            //// Форматировать диаграмму
            //chart1.BackColor = Color.Gray;
            //chart1.BackSecondaryColor = Color.WhiteSmoke;
            //chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            //chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            //chart1.BorderlineColor = Color.Gray;
            //chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            //// Форматировать область диаграммы
            //chart1.ChartAreas[0].BackColor = Color.Wheat;

            //// Добавить и форматировать заголовок
            //chart1.Titles.Add("Диаграммы");
            //chart1.Titles[1].Font = new Font("Utopia", 16);

            //chart1.Series.Add(new Series("ColumnSeries")
            //{
            //    ChartType = SeriesChartType.Pie
            //});

            //// Salary series data
            //double[] yValues = { 2222, 2724, 2720, 3263, 2445 };
            //string[] xValues = { "France", "Canada", "Germany", "USA", "Italy" };
            //chart1.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);

            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
