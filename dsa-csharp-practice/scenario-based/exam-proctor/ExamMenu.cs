using System;

namespace ExamProctor {

    public class ExamMenu {
        LinkedListStack stack = new LinkedListStack();
        AnswerStore store = new AnswerStore();

        public void ShowMenu(){
            while(true){
                Console.WriteLine("======WELCOME TO EXAM PROCTOR======");
                Console.WriteLine("1.Visit Question");
                Console.WriteLine("2.Go Back");
                Console.WriteLine("3.View Navigation");
                Console.WriteLine("4.Submit Exam");
                Console.WriteLine("5.Exit");

                int choice = int.Parse(Console.ReadLine()!);

                switch(choice){
                    case 1:
                        Console.Write("Enter Question ID: ");
                        int qid = int.Parse(Console.ReadLine()!);
                        stack.Push(qid);

                        Console.Write("Enter Answer: ");
                        string ans = Console.ReadLine()!;
                        store.SaveAnswer(qid, ans);
                        break;

                    case 2:
                        Console.WriteLine("Back to Question: " + stack.Pop());
                        break;

                    case 3:
                        stack.Display();
                        break;

                    case 4:
                        Console.WriteLine("Final Score: " + store.Evaluate());
                        return;

                    case 5:
                        return;
                }
            }
        }
    }
}
