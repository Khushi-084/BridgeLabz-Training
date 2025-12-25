using System;
class VotingAge{

  // Method to check if a student can vote
  public bool VotingEligibility(int age){
        if (age < 0){
            return false;
        }else if (age >= 18){
            return true;
        }else{
          return false;
        }
    }

  public static void Main(string[] args){

    // Create an array to store student ages
    int[] studentAge = new int[10];
    Voting checker = new Voting();
    for (int i = 0; i < studentAge.Length; i++){
      Console.Write("Enter age of student " + (i + 1) + ": ");
      studentAge[i] = Convert.ToInt32(Console.ReadLine());


      // Checking if the student can vote or not
      bool canVote = checker.VotingEligibilitye(studentAge[i]);
      if (canVote){
        Console.WriteLine("Student " + (i + 1) + " can vote.");
      }else{
        Console.WriteLine("Student " + (i + 1) + " cannot vote.");
      }
    }
  }


  
}
