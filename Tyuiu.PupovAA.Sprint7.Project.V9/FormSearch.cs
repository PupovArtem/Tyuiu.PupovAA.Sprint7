using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PupovAA.Sprint7.Project.V9.Lib;


namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    public partial class FormSearch_PAA : Form
    {
        
        private DataGridView mainGrid;

        public FormSearch_PAA(DataGridView grid)
        {
            InitializeComponent();
            mainGrid = grid; 
            ControlBox = false;
            this.FormClosing += FormSearch_FormClosing;
        }

        private void buttonSearchword_PAA_Click(object sender, EventArgs e)
        {
            string text = textBoxSearchResult_PAA.Text;

            if (!string.IsNullOrWhiteSpace(text))
            {
                
                string[,] data = GetGridDataFromMain();

                
                var matches = DataService.SearchWord(data, text);

                
                foreach (var match in matches)
                {
                    if (match.Row < mainGrid.Rows.Count && match.Column < mainGrid.Columns.Count) 
                    {
                        mainGrid[match.Column, match.Row].Style.BackColor = Color.LightGreen;
                    }
                }

                // 4. Результат
                if(matches.Count > 0)
                {
                    MessageBox.Show($"Найдено: {matches.Count}","Поздравлю!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
                else 
                {
                    MessageBox.Show("Не найдено", "Не поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("Введите текст для поиска", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (this.DialogResult != DialogResult.OK)
            {
                Clear();
            }
        }



        private string[,] GetGridDataFromMain()
        {
            int rows = mainGrid.RowCount;
            int cols = mainGrid.ColumnCount;
            string[,] array = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = mainGrid.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            return array;
        }

        
        private void Clear()
        {
            for (int i = 0; i < mainGrid.Rows.Count; i++)
            {
                for (int j = 0; j < mainGrid.Columns.Count; j++)
                {
                    mainGrid.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void buttonCloseSearch_PAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

