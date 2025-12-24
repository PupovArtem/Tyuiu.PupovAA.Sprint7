using System;
using System.ComponentModel;
using System.Windows.Forms;
using Tyuiu.PupovAA.Sprint7.Project.V9.Lib;


namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    public partial class FormMainProject_PAA : Form
    {

        public FormMainProject_PAA()
        {
            InitializeComponent();
            buttonSaveFile_PAA.Enabled = false;



            dataGridViewVideo_PAA.Columns[0].ValueType = typeof(int);
            dataGridViewVideo_PAA.Columns[2].ValueType = typeof(double);


            dataGridViewVideo_PAA.Columns[4].ValueType = typeof(double);





            dataGridViewVideo_PAA.DataError += (s, e) =>
            {
                MessageBox.Show("Введены буквы вместо цифр!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.ThrowException = false;

            };


            dataGridViewVideo_PAA.SortCompare += dataGridViewVideo_PAA_SortCompare;




        }


        private string filePath;

        private void buttonOpenFile_PAA_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;


                        string[,] matrix = DataService.LoadFile(filePath);


                        dataGridViewVideo_PAA.Rows.Clear();


                        int rowCount = matrix.GetLength(0);
                        int colCount = matrix.GetLength(1);


                        for (int i = 0; i < rowCount; i++)
                        {

                            string[] rowValues = new string[colCount];

                            for (int j = 0; j < colCount; j++)
                            {
                                rowValues[j] = matrix[i, j];
                            }


                            dataGridViewVideo_PAA.Rows.Add(rowValues);
                        }


                        buttonSaveFile_PAA.Enabled = true;

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка загрузки файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void buttonSaveFile_PAA_Click(object sender, EventArgs e)
        {


            try
            {
                int rows = dataGridViewVideo_PAA.RowCount;
                int cols = dataGridViewVideo_PAA.ColumnCount;

                string[,] array = new string[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        object Value = dataGridViewVideo_PAA.Rows[i].Cells[j].Value;
                        string result;
                        if (Value != null)
                        {
                            result = (string)Value;
                        }
                        else
                        {
                            result = "";
                        }
                        array[i, j] = result;
                    }
                }
                bool save = DataService.SaveToFile(filePath, array);
                if (save)
                {
                    MessageBox.Show("Файл сохранен!", "Поздравляю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_PAA_Click(object sender, EventArgs e)
        {
            FormAbout_PAA formAbout = new FormAbout_PAA();
            formAbout.ShowDialog();
        }

        private void buttonAddRows_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewVideo_PAA.Rows.Add();

            }
            catch
            {
                MessageBox.Show($"Ошибка в добавлении строки", "Ошибка");
            }
        }

        private void buttonDelete_PAA_Click(object sender, EventArgs e)
        {
            try
            {

                int rows = dataGridViewVideo_PAA.RowCount;
                int cols = dataGridViewVideo_PAA.ColumnCount;
                string[,] data = new string[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        data[i, j] = dataGridViewVideo_PAA.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }


                string result = DataService.DeleteRows(data);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Нет пустых строк", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                string[] strIndexes = result.Split(',');
                for (int i = strIndexes.Length - 1; i >= 0; i--)
                {
                    int idx = int.Parse(strIndexes[i]);
                    if (idx < dataGridViewVideo_PAA.Rows.Count)
                    {
                        dataGridViewVideo_PAA.Rows.RemoveAt(idx);
                    }
                }



                MessageBox.Show($"Удалено количество строк:{strIndexes.Length}", "Поздравлю! Вы смогли удалить строку");
            }
            catch
            {
                MessageBox.Show($"Ошибка в удалении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewVideo_PAA_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0 || e.Column.Index == 4)
            {
                if (e.Column.Index == 0 || e.Column.Index == 4)
                {
                    double num1 = ConvertToDouble(e.CellValue1);
                    double num2 = ConvertToDouble(e.CellValue2);

                    e.SortResult = num1.CompareTo(num2);
                    e.Handled = true;
                }
            }

        }
        private double ConvertToDouble(object value)
        {
            if (value == null)
            {
                return 0;
            }
            string str = value.ToString();
            return double.TryParse(str, out double result) ? result : 0;
        }

        private void dataGridViewVideo_PAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenSearch_PAA_Click(object sender, EventArgs e)
        {
            FormSearch_PAA searchForm = new FormSearch_PAA(dataGridViewVideo_PAA);
            searchForm.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStatistics_PAA statisticsForm = new FormStatistics_PAA(dataGridViewVideo_PAA);
            statisticsForm.ShowDialog();
        }
    }
}
