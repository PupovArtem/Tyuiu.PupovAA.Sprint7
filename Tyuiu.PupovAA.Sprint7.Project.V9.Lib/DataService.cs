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
                    if (cellValue.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matches.Add((i, j));
                     }
                }
            }
            return matches;
        }
            
        
    }
}
