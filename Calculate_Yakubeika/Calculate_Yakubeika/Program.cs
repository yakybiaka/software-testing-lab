using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Yakubeika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, wait! Reading file Students.exe");

            string Path = Environment.CurrentDirectory + "\\Students.xlsx";
            Microsoft.Office.Interop.Excel.Application ObjWorkExcel = new Microsoft.Office.Interop.Excel.Application(); //open Excel
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(Path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //open file 
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1]; //get Sheet
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell); 

            int lastColumn = (int)lastCell.Column;
            int lastRow = (int)lastCell.Row;
            string[,] list = new string[lastCell.Row, lastCell.Column]; //list values
            for (int i = 0; i < (int)lastCell.Row; i++)
                for (int j = 0; j < (int)lastCell.Column; j++)
                    list[i, j] = ObjWorkSheet.Cells[i + 1, j + 1].Text.ToString();

            Console.WriteLine("Actions : \n 1 - Academic Performance of ALL Students \n 2 - Academic Performance of ONE Student \n 3 - Average Score of the whole Group \n 0 - Exit");

            int caseSwitch;

            while (true)
            {
                try
                {
                    Console.WriteLine("\nSelect an action:");
                    caseSwitch = Convert.ToInt32(Console.ReadLine());
                    switch (caseSwitch)
                    {
                        case 1:
                            Print_All(list, lastRow, lastColumn);
                            break;
                        case 2:
                            Average_Score_All(list, lastRow, lastColumn);
                            break;
                        case 3:
                            Average_Score_One(list, lastRow, lastColumn);
                            break;
                        default:
                            Console.WriteLine("Wrong case!");
                            break;
                        case 0:
                            return;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Wrong case!");
                }
            }
            
        }
        public static void Print_All(string[,] list, int lastRow, int lastColumn)
        {
            for (int i = 0; i < lastRow; i++)
            {
                for (int j = 0; j < lastColumn; j++)
                {
                    Console.Write(list[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
            public static void Average_Score_All(string[,] list, int lastRow, int lastColumn)
            {
            int k = 0;
            float sum =0;
            double average = 0;
                for (int i = 1; i < lastRow; i++)
                {
                    for (int j = 1; j < lastColumn; j++)
                    {
                     k++;
                     sum += Convert.ToInt32(list[i, j]);
                    }
                }
            average = sum / k;
            Console.WriteLine("Average Score for Group: "+average);
            }

        public static void Average_Score_One(string[,] list, int lastRow, int lastColumn)
        {
            Console.WriteLine("Enter name of Student");
            string name = Console.ReadLine();
            float sum = 0,average_stud=0;
            int k=0;
            for (int i = 0; i < lastRow; i++)
            {
                if (list[i, 0] == name)
                {
                    for (int j = 1; j < lastColumn; j++)
                    {
                        sum += Convert.ToInt32(list[i, j]);
                        k++;
                    }
                }
            }
            if (sum == 0) Console.WriteLine("Student with this Name isn't in the Databasse");
            else
            {
                average_stud = sum / k;
                Console.WriteLine("Average Score for " + name + ": " + average_stud);
            }
        }
    }
}
