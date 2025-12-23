 using System;
class GradeCalculator{
  static void Main(string[] args){
    //taking input from user
    Console.Write("Enter Physics marks: ");
    int physics = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Chemistry marks: ");
    int chemistry = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Maths marks: ");
    int maths = Convert.ToInt32(Console.ReadLine());

    //calculating average and grade
    double average = (physics + chemistry + maths) / 3.0;
    char grade;
    string remarks;
    if (average >= 80){
      grade = 'A';
      remarks = "Level 4-Above agency-normalized standards";
    }else if (average >= 70){
      grade = 'B';
      remarks = "Level 3-At agency-normalized standards";
    }else if (average >= 60){
      grade = 'C';
      remarks = "Level 2-Below but approaching agency-normalized standards";
    }else if (average >= 50){
      grade = 'D';
      remarks = "Level 1-Well below agency-normalized standards";
    }else if (average >= 40){
      grade = 'E';
      remarks = "Level 1-Too below agency-normalized standards";
    }else{
      grade = 'R';
      remarks = "Remedial standards";
    }


    //output
    Console.WriteLine("\n--- Result ---");
    Console.WriteLine("Average Marks: " + average);
    Console.WriteLine("Grade: " + grade);
    Console.WriteLine("Remarks: " + remarks);
  }
}
