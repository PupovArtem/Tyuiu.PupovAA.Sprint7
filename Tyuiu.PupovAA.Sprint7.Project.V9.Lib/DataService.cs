using System.Drawing;

namespace Tyuiu.PupovAA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public static string[,] LoadFile(string filePath)
        {
            string[] allLines = File.ReadAllLines(filePath);

            int rowCount = allLines.Length;
            int colCount = allLines[0].Split(';').Length;


            string[,] result = new string[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] cells = allLines[i].Split(';');
                for (int j = 0; j < colCount; j++)
                {
                    if (j < cells.Length)
                    {
                        result[i, j] = cells[j];
                    }
                    else
                    {
                        result[i, j] = "";
                    }
                }
            }

            return result;
        }

        public static bool SaveToFile(string filePath, string[,] data)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                int rows = data.GetLength(0);
                int cols = data.GetLength(1);
                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    bool rowHasData = false;
                    for (int j = 0; j < cols; j++)
                    {
                        if (data[i, j] != null && !string.IsNullOrWhiteSpace(data[i, j]))
                        {
                            rowHasData = true;
                            str += data[i, j];

                            if (j == cols - 1)
                            {
                                continue;
                            }
                            else
                            {
                                str += ";";
                            }
                        }
                    }

                    if (rowHasData)
                    {
                        File.AppendAllText(filePath, str + Environment.NewLine);
                    }
                    str = "";
                }

                return true;
            }
            catch
            {
                return false;
            }

        }
        public static string DeleteRows(string[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                bool isEmpty = true;
                for (int j = 0; j < cols; j++)
                {
                    if (!string.IsNullOrWhiteSpace(data[i, j]))
                    {
                        isEmpty = false;
                        break;
                    }
                }

                if (isEmpty)
                {
                    if (!string.IsNullOrEmpty(result))
                        result += ",";
                    result += i.ToString();
                }
            }

            return result;
        }
        

        public static List<(int Row, int Column)> SearchWord(string[,] data, string searchText)
        {          
            var matches = new List<(int, int)>();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return matches;
            }
            

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string cellValue;
                    if (data[i, j] != null)
                    {
                        cellValue = data[i, j];
                    }
                    else
                    {
                        cellValue = "";
                    }
                    if (cellValue.Contains(searchText, StringComparison.OrdinalIgnoreCase)) //порядковое сравнение без учёта регистра
                    {
                        matches.Add((i, j));
                     }
                }
            }
            return matches;
        }
        
        public static int GetCount_PAA(string[,] data) //подсчёт количества видео
        {
            if (data == null || data.GetLength(0) <= 1)
                return 0;
                
            return data.GetLength(0);
        }

        
        public static double GetSum_PAA(string[,] data, int columnIndex)//сумма в столбце
        {
            if (data == null || columnIndex < 0 || columnIndex >= data.GetLength(1))
                return 0;

            double sum = 0;
            int rows = data.GetLength(0);

            for (int i =0; i < rows; i++) 
            {
                if (double.TryParse(data[i, columnIndex], out double value))
                {
                    sum += value;
                }
            }
            return sum;
        }

        
        public static double GetAverage_PAA(string[,] data, int columnIndex)  //среднее значение
        {
            int count = GetCount_PAA(data);
            if (count == 0)
            {
                return 0;
            }
            double sum = GetSum_PAA(data, columnIndex);
            return Math.Round(sum / count,3);
        }

        
        public static double GetMin_PAA(string[,] data, int columnIndex)  //минимальное значение
        {
            if (data == null || data.GetLength(0) <= 1)
                return 0;

            double min = double.MaxValue;
            bool found = false;

            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, columnIndex], out double value))
                {
                    if (value < min) 
                    {
                        min = value;
                        found = true;
                    }
                }
            }

            return found ? min : 0;
        }

        
        public static double GetMax_PAA(string[,] data, int columnIndex) //максимальное значение
        {
            if (data == null || data.GetLength(0) <= 1)
                return 0;

            double max = double.MinValue;
            bool found = false;

            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, columnIndex], out double value))
                {
                    if (value > max) 
                    {
                        max = value;
                        found = true;
                    }
                }
            }

            return found ? max : 0;
        }  
        
    }
}
