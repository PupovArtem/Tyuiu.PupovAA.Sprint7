using System.Windows.Forms;


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

                        
                        string[,] matrix = LoadFromFile(filePath);

                        
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

                
                var saved = SaveToFileWithLibrary(filePath, rows, cols);

                if (saved)
                {
                    MessageBox.Show("Файл сохранен!", "Поздравляю!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

                MessageBox.Show("Файл сохранен!", "Поздравляю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
    }
}
