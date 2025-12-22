using System.Windows.Forms;
using Tyuiu.PupovAA.Sprint7.Project.V9.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            buttonSaveFile_PAA.Enabled = false;
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


                        string[,] matrix = DataService.LoadFromFile(filePath);


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
                        var cellValue = dataGridViewVideo_PAA.Rows[i].Cells[j].Value;
                        string result;
                        if (cellValue != null)
                        {
                            result = (string)cellValue;
                        }
                        else
                        {
                            result = "";
                        }
                        array[i, j] = result; 
                    }
                }
                bool save = DataService.SaveArrayToFile(filePath, array);
                if (save)
                {
                    MessageBox.Show("Файл сохранен!", "Поздравляю!",MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
