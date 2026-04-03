namespace ExamProctor {

    public class StackNode {
        public int questionId;
        public StackNode? next;

        public StackNode(int questionId){
            this.questionId = questionId;
            this.next = null;
        }
    }
}
