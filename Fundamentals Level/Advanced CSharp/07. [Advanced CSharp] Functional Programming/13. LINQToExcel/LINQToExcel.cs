using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ExcelLibrary.SpreadSheet;

class LINQToExcel
{
    static void Main()
    {
        List<Student> studentsData = new List<Student>();
        using (StreamReader reader = new StreamReader("Students-data.txt", Encoding.UTF8))
        {
            reader.ReadLine();
            string currentLine = reader.ReadLine();
            string[] currentLineTokens;
            while (currentLine != null)
            {
                currentLineTokens = currentLine.Split(new char[] {'\t', ' '}, StringSplitOptions.RemoveEmptyEntries);

                int id = int.Parse(currentLineTokens[0]);
                string firstName = currentLineTokens[1];
                string lastName = currentLineTokens[2];
                string email = currentLineTokens[3];
                string gender = currentLineTokens[4];
                string studentType = currentLineTokens[5];
                int examResult = int.Parse(currentLineTokens[6]);
                int homeworkSent = int.Parse(currentLineTokens[7]);
                int homeworkEvaluated = int.Parse(currentLineTokens[8]);
                double teamworkScore = double.Parse(currentLineTokens[9]);
                int attendancesCount = int.Parse(currentLineTokens[10]);
                double bonus = double.Parse(currentLineTokens[11]);

                studentsData.Add(new Student(id, firstName, lastName, email, gender, studentType, 
                    examResult, homeworkSent, homeworkEvaluated, teamworkScore, attendancesCount, bonus));

                currentLine = reader.ReadLine();
            }
        }

        var studentsQuery = from student in studentsData
                            where student.StudentType.Equals("Online")
                            orderby student.Result descending 
                            select student;


        string path =
            @"D:\Visual Studio projects\07. [Advanced CSharp] Functional Programming\13. LINQToExcel\bin\Debug\Students-data.xls";
        Workbook workbook = new Workbook();
        Worksheet worksheet = new Worksheet("First Sheet");
        workbook.Worksheets.Add(worksheet);
        workbook.Save(path);

        Workbook book = Workbook.Load(path);
        Worksheet sheet = book.Worksheets[0];

        int row = 0;
        foreach (Student student in studentsQuery)
        {
            sheet.Cells[row, 0] = new Cell(student.ID);
            sheet.Cells[row, 1] = new Cell(student.FirstName);
            sheet.Cells[row, 2] = new Cell(student.LastName);
            sheet.Cells.ColumnWidth[(ushort)row, 3] = 3000;
            sheet.Cells[row, 3] = new Cell(student.Email);
            sheet.Cells[row, 4] = new Cell(student.Gender);
            sheet.Cells[row, 5] = new Cell(student.StudentType);
            sheet.Cells[row, 6] = new Cell(student.ExamResult);
            sheet.Cells[row, 7] = new Cell(student.HomeworkSent);
            sheet.Cells[row, 8] = new Cell(student.HomeworkEvaluated);
            sheet.Cells[row, 9] = new Cell(student.TeamworkScore);
            sheet.Cells[row, 10] = new Cell(student.AttendancesCount);
            sheet.Cells[row, 11] = new Cell(student.Bonus);
            sheet.Cells[row, 12] = new Cell(student.Result);

            row++;
        }

        book.Worksheets.Add(sheet);
        book.Save(@"D:\Visual Studio projects\07. [Advanced CSharp] Functional Programming\13. LINQToExcel\bin\Debug\Students-data.xls");
    }
}

