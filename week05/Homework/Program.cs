using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment("Isaac", "Math", "Problems 1-10", "Section 2.1");
        Console.WriteLine(mathAssignment1.GetHomeworkList());


        WritingAssignment writingAssignment1 = new WritingAssignment("Jane Doe", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
}








    }

   