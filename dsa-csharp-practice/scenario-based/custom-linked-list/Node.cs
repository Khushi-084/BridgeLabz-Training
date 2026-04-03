namespace CustomLinkedList{
    public class Node<T>{
        public T Data;
        public Node<T>? Next;   // nullable to remove warning

        public Node(T data){
            Data = data;
            Next = null;
        }
    }
}
