using System.Windows.Forms;

namespace Tyuiu.SpirinIS.Sprint7.Project.V9
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

                        string[] lines = File.ReadAllLines(filePath);
                        dataGridViewVideo_PAA.Rows.Clear();

                        foreach (string line in lines)
                        {
                            string[] values = line.Split(';');
                            dataGridViewVideo_PAA.Rows.Add(values);
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
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                int rows = dataGridViewVideo_PAA.RowCount;
                int cols = dataGridViewVideo_PAA.ColumnCount;
                string str = "";

                for (int i = 0; i < rows; i++)
                {



                    bool rowHasData = false;
                    for (int j = 0; j < cols; j++)
                    {


                        if (dataGridViewVideo_PAA.Rows[i].Cells[j].Value != null && !string.IsNullOrWhiteSpace(dataGridViewVideo_PAA.Rows[i].Cells[j].Value.ToString()))
                        {
                            rowHasData = true;
                            str += dataGridViewVideo_PAA.Rows[i].Cells[j].Value;
                        }

                        if (j != cols - 1)
                        {
                            str += ";";
                        }
                    }
                    if (rowHasData)
                    {
                        File.AppendAllText(filePath, str + Environment.NewLine);
                    }
                    str = "";
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
