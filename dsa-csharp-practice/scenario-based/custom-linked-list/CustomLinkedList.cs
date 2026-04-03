using System;
namespace CustomLinkedList{
    public class CustomLinkedList<T>{
        private Node<T>? head;  // nullable to remove warning

        public void AddLast(T data){
            Node<T> newNode = new Node<T>(data);

            if (head == null){
                head = newNode;
                return;
            }

            Node<T> temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        public bool Remove(Predicate<T> match){
            if (head == null) return false;

            if (match(head.Data)){
                head = head.Next;
                return true;
            }

            Node<T> current = head;
            while (current.Next != null){
                if (match(current.Next.Data)){
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T? Find(Predicate<T> match){
            Node<T>? temp = head;
            while (temp != null){
                if (match(temp.Data))
                    return temp.Data;
                temp = temp.Next;
            }
            return default;
        }

        public bool Exists(Predicate<T> match){
            return !Equals(Find(match), default(T));
        }

        public void Display(Action<T> action){
            Node<T>? temp = head;
            while (temp != null){
                action(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
