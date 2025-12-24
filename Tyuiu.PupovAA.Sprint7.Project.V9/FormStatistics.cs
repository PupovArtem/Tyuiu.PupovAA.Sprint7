using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.PupovAA.Sprint7.Project.V9.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    public partial class FormStatistics_PAA : Form
    {
        private DataGridView mainGrid;
        public FormStatistics_PAA(DataGridView grid)
        {
            InitializeComponent();
            mainGrid = grid;
        }
        private string[,] GetMatrix()
        {
            int rows = mainGrid.RowCount;
            int cols = mainGrid.ColumnCount;
            string[,] data = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = mainGrid.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] data = GetMatrix();

            int count = DataService.GetCount_PAA(data);
            double sum = DataService.GetSum_PAA(data, 4);
            double average = DataService.GetAverage_PAA(data, 4);
            double min = DataService.GetMin_PAA(data, 4);
            double max = DataService.GetMax_PAA(data, 4);

            textBoxCount_PAA.Text = count.ToString();
            textBoxSumCol_PAA.Text = sum.ToString();
            textBoxMean_PAA.Text = average.ToString();
            textBoxMin_PAA.Text = min.ToString();
            textBoxMax_PAA.Text = max.ToString();

            chartresult_PAA.Series.Clear();
            Series series = new Series("Статистика");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY(1, count);
            series.Points.AddXY(2, sum);
            series.Points.AddXY(3, average);
            series.Points.AddXY(4, min);
            series.Points.AddXY(5, max);

            chartresult_PAA.Series.Add(series);

            chartresult_PAA.Series[0].Points[0].AxisLabel = "Кол-во видео";
            chartresult_PAA.Series[0].Points[1].AxisLabel = "Сумма";
            chartresult_PAA.Series[0].Points[2].AxisLabel = "Среднее";
            chartresult_PAA.Series[0].Points[3].AxisLabel = "Минимум";
            chartresult_PAA.Series[0].Points[4].AxisLabel = "Максимум";

            chartresult_PAA.ChartAreas[0].AxisX.Interval = 1; 
            chartresult_PAA.ChartAreas[0].AxisX.Title = "Функции статистики";
            chartresult_PAA.ChartAreas[0].AxisY.Title = "Значения";
        }
    }
}
