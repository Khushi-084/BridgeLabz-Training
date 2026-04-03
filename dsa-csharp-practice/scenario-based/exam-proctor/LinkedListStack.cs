namespace ExamProctor {

    public class LinkedListStack {
        private StackNode? top;

        public LinkedListStack(){
            top = null;
        }

        public void Push(int qid){
            StackNode newNode = new StackNode(qid);
            newNode.next = top;
            top = newNode;
        }

        public int Pop(){
            if(top == null){
                System.Console.WriteLine("No previous question!");
                return -1;
            }

            int val = top.questionId;
            top = top.next;
            return val;
        }

        public void Display(){
            if(top == null){
                System.Console.WriteLine("Navigation Stack Empty");
                return;
            }

            StackNode? temp = top;
            while(temp != null){
                System.Console.Write(temp.questionId + " ");
                temp = temp.next;
            }
            System.Console.WriteLine();
        }
    }
}
