using System.Collections.Generic;

namespace ExamProctor {

    public class AnswerStore {
        private Dictionary<int, string> answers = new Dictionary<int, string>();

        public void SaveAnswer(int qid, string answer){
            answers[qid] = answer;
        }

        public int Evaluate(){
            int score = 0;
            foreach(var a in answers){
                if(a.Value == "A") score++;
            }
            return score;
        }
    }
}
